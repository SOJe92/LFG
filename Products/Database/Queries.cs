namespace SearchAndRescue.Products.Database
{
    public static class Queries
    {
        public static string GetByUserId(string columns) => $"SELECT {columns} FROM public.get_productss(@puserid)";
        public static string Get(string columns) => $"SELECT {columns} FROM public.get_products()";
    }
}
