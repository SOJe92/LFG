namespace SearchAndRescue.Entity.Database
{
    public static class Queries
    {
        public static string Get(string columns) => $"SELECT {columns} FROM private.entity WHERE id = @id";

        public static string Delete(string parameters) => $"DELETE FROM private.entity WHERE {parameters}";
    }
}
