namespace SearchAndRescue.Configuration.Dtos.Get
{
    public class Configuration
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<ContactType> ContactTypes { get; set; }
        public IEnumerable<EntityFavourites> EntityFavourites { get; set; }
        public IEnumerable<EntityType> EntityTypes { get; set; }
        public IEnumerable<Feature> Features { get; set; }
        public IEnumerable<Keyword> Keywords { get; set; }
        public IEnumerable<PointOfInterest> PointOfInterests { get; set; }
        public IEnumerable<ProductFavourites> ProductFavourites { get; set; }
        public IEnumerable<Role> Roles { get; set; }
        public IEnumerable<Sector> Sectors { get; set; }
        public IEnumerable<Service> Services { get; set; }
    }
}
