using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Model;
using static Model.DTO;

namespace DataAccess
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository() : base()
        {
        }
        private User DataRowToUser(DataRow row)
        {
            User user = new User();
            var properties = typeof(User).GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                if (row[i] != DBNull.Value)
                {
                    properties[i].SetValue(user, row[i]);
                }
            }
            return user;
        }
        public Task<List<User>> GetAllUsers()
        {
            string query = "SELECT * FROM Users";
            DataTable table = GetData(query);
            List<User> users = new List<User>();
            foreach (DataRow row in table.Rows)
            {
                users.Add(DataRowToUser(row));
            }

            return Task.FromResult(users);
        }
        public Task<List<User>> GetUserByTerm(string term)
        {
            string query = $"SELECT * FROM Users WHERE UserName LIKE '%{term}%'";
            DataTable table = GetData(query);
            List<User> users = new List<User>();
            foreach (DataRow row in table.Rows)
            {
                users.Add(DataRowToUser(row));
            }

            return Task.FromResult(users);
        }
        //public Task<User> GetUserById(string userId)
        //{
        //    string query = $"SELECT * FROM Users WHERE UserID = '{userId}'";
        //    DataTable table = GetData(query);
        //    if (table.Rows.Count > 0)
        //    {
        //        return Task.FromResult(DataRowToUser(table.Rows[0]));
        //    }
        //    return Task.FromResult<User>(null);
        //}
        public Task<bool> AddUser(User user)
        {
            if (CheckExists("Users", "UserName", user.UserName))
            {
                throw new Exception("Username already exists.");
            }
            var parameters = new Dictionary<string, object>
            {
                { "UserID", user.UserID },
                { "UserName", user.UserName },
                { "UserPassword", user.UserPassword },
                { "UserPhone", user.UserPhone },
                { "UserRole", user.UserRole }
            };

            Insert("Users", parameters);
            return Task.FromResult(true);
        }

        public Task<bool> UpdateUser(User user)
        {
            var parameters = new Dictionary<string, object>
            {
                { "UserName", user.UserName },
                { "UserPassword", user.UserPassword },
                { "UserPhone", user.UserPhone },
                { "UserRole", user.UserRole }
            };
            string condition = $"UserID = '{user.UserID}'";
            Update("Users", parameters, condition);
            return Task.FromResult(true);
        }
        
        public Task<List<GetUsername>> GetAllUserName()
        {
            string query = "SELECT UserName FROM Users";
            DataTable dt = GetData(query);
            List<GetUsername> list = new List<GetUsername>();
            foreach (DataRow row in dt.Rows)
            {
                GetUsername item = new GetUsername();
                var properties = typeof(GetUsername).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(item, row[i]);
                    }
                }
                list.Add(item);
            }
            return Task.FromResult(list);
        }

        public Task<bool> DeleteUser(string userId)
        {
            string condition = $"UserID = '{userId}'";
            Delete("Users", condition);
            return Task.FromResult(true);
        }

        //public async Task<User> GetUserByUsernameAsync(string username)
        //{
        //    string query = $"SELECT * FROM Users WHERE UserName = '{username}'";
        //    DataTable table = GetData(query);
        //    if (table.Rows.Count > 0)
        //    {
        //        return DataRowToUser(table.Rows[0]);
        //    }
        //    return null;
        //}
        public Task<bool> ValidatePassword(string username, string inputPassword)
        {
            string storedPassword = GetValue("Users", "UserPassword", $"UserName = '{username}'");
            return Task.FromResult(storedPassword == inputPassword);
        }

        //public Task<bool> UpdateUserPasswordAsync(string username, string password)
        //{
        //    var parameters = new Dictionary<string, object>
        //    {
        //        { "UserPassword", password }
        //    };
        //    string condition = $"UserName = '{username}'";
        //    Update("Users", parameters, condition);
        //    return Task.FromResult(true);
        //}
        //public Task<bool> UpdateUserPhoneAsync(string username, string phone)
        //{
        //    var parameters = new Dictionary<string, object>
        //    {
        //        { "UserPhone", phone }
        //    };
        //    string condition = $"UserName = '{username}'";
        //    Update("Users", parameters, condition); 
        //    return Task.FromResult(true); 
        //}

        //public Task<bool> UpdateUserRoleAsync(string username, string role)
        //{
        //    var parameters = new Dictionary<string, object>
        //    {
        //        { "UserRole", role }
        //    };
        //    string condition = $"UserName = '{username}'";
        //    Update("Users", parameters, condition);
        //    return Task.FromResult(true); 
        //}

        //public Task<string> GenerateNewUserIDAsync()
        //{
        //    string query = "SELECT MAX(CAST(UserID AS INT)) FROM Users";
        //    using (SqlConnection conn = new SqlConnection(_connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        conn.Open();
        //        object result = cmd.ExecuteScalar();
        //        int newCode = 1;
        //        if (result != DBNull.Value)
        //        {
        //            newCode = Convert.ToInt32(result) + 1;
        //        }
        //        return Task.FromResult(newCode.ToString("D2")); 
        //    }
        //}
        public Task<string> GetUserRole(string username, string password)
        {
            string condition = $"UserName = '{username}' AND UserPassword = '{password}'";
            string role = GetValue("Users", "UserRole", condition);

            if (string.IsNullOrEmpty(role))
            {
                throw new Exception($"No role found for the user: {username}");
            }
            return Task.FromResult(role);
        }
    }
}
