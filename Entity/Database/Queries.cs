namespace SearchAndRescue.Entity.Database
{
    public static class Queries
    {
        public static string Get(string columns) => $"SELECT {columns} FROM public.entities WHERE id = @id";

        public static string Delete(string parameters) => $"DELETE FROM public.entities WHERE {parameters}";
    }
}
