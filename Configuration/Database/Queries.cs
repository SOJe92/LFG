namespace SearchAndRescue.Configuration.Database
{
    public class Queries
    {
        public static string GetCategories => "SELECT * FROM public.categories";
        public static string GetContactTypes => "SELECT * FROM public.contacttypes";
        public static string GetEntityFavourites => "SELECT * FROM public.favourite_entities";
        public static string GetEntityTypes => "SELECT * FROM public.entitytypes";
        public static string GetFeatures => "SELECT * FROM settings.features";
        public static string GetKeywords => "SELECT * FROM public.keywords";
        public static string GetPointOfInterests => "SELECT * FROM public.poi";
        public static string GetProductFavourites => "SELECT * FROM public.favourite_products";
        public static string GetRoles => "SELECT * FROM settings.role";
        public static string GetSectors => "SELECT * FROM public.sectors";
        public static string GetServices => "SELECT * FROM public.services";
        public static string GetSectorServices => "SELECT * FROM lookup.sectorservices";
    }
}
