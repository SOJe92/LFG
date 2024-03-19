namespace SearchAndRescue.Entities.Database
{
    public static class Queries
    {
        public static string GetAll(string columns) => $"SELECT {columns} FROM public.get_entities(@puserid)";

        public static string Get(string columns) => $"SELECT {columns} FROM public.entities WHERE id = @id";

        public static string Delete => "DELETE FROM public.entities WHERE ";
    }
}
