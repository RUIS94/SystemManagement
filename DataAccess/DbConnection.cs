namespace DataAccess
{
    public static class DbConnection
    {
        public static string ConnectionString { get; } =
            "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=E:\\SystemManagement\\Model\\Database.mdf;Integrated Security=true";
    }
}
