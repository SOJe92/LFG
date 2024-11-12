namespace SearchAndRescue.Entities.Database
{
    public static class Queries
    {
        public static string GetByUserId => "public.get_entities(@puserid)";
        public static string Get => "public.get_entities()";
    }
}
