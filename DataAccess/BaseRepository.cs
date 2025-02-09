using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
namespace DataAccess
{
    public class BaseRepository
    {
        protected readonly string _connectionString;
        public BaseRepository()
        {
            _connectionString = DbConnection.ConnectionString;
        }
        public DataTable GetData(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
        public string GetValue(string tableName, string columnName, string condition)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand($"SELECT {columnName} FROM {tableName} WHERE {condition}", conn))
                {
                    cmd.Parameters.AddWithValue("@Condition", condition);
                    object result = cmd.ExecuteScalar();
                    return result.ToString();
                }
            }
        }
        public void Insert(string tableName, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        var columns = string.Join(",", parameters.Keys);
                        var values = string.Join(",", parameters.Keys.Select(k => "@" + k));
                        string query = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";
                        using (SqlCommand cmd = new SqlCommand(query, conn, trans))
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue("@" + param.Key, param.Value);
                            }
                            cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                }
            }
        }
        public void Update(string tableName, Dictionary<string, object> parameters, string condition)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        var setValue = string.Join(",", parameters.Keys.Select(k => $"{k} = @{k}"));
                        string query = $"UPDATE {tableName} SET {setValue} WHERE {condition}";
                        using (SqlCommand cmd = new SqlCommand(query, conn, trans))
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue("@" + param.Key, param.Value);
                            }
                            cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                }
            }
        }
        public void Delete(string tableName, string condition)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        string query = $"DELETE FROM {tableName} WHERE {condition}";
                        using (SqlCommand cmd = new SqlCommand(query, conn, trans))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                }
            }
        }
        public bool CheckExists(string tableName, string columnName, string value)
        {
            string query = $"SELECT COUNT(1) FROM {tableName} WHERE {columnName} = @Value";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Value", value);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public bool ValueMatchs(string tableName, string columnName, string valueToMatch, string condition)
        {
            string query = $"SELECT COUNT(1) FROM {tableName} WHERE {columnName} = @Value AND {condition}";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Value", valueToMatch);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public int GenerateNewId(string tableName, string idColumn)
        {
            string query = $"SELECT MAX({idColumn}) FROM {tableName}";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
