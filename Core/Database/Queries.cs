namespace SearchAndRescue.Core.Database
{
    public static class Queries
    {
        public static string GetById(string columns, string table, string identifierColumn) => $"SELECT {columns} FROM {table} WHERE {identifierColumn} = @{identifierColumn}";

        public static string Get(string columns, string table) => $"SELECT {columns} FROM {table}";
    }
}
