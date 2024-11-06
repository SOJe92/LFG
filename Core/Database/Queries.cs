namespace SearchAndRescue.Core.Database
{
    public static class Queries
    {
        public static string GetById(string columns, string table, string identifierColumn)
        {
            return $"SELECT {columns} FROM {table} WHERE {identifierColumn} = @{identifierColumn}";
        }

        public static string GetById(string columns, string table, string[] identifierColumns)
        {
            return $"SELECT {columns} FROM {table} WHERE {identifierColumns.Select((column) => { return $"{column} = p{column.Replace("_", "")}"; })}";
        }

        public static string Get(string columns, string table)
        {
            return $"SELECT {columns} FROM {table}";
        }
    }
}
