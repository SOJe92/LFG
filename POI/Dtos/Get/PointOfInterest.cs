using PointOfInterestBase = SearchAndRescue.POI.Dtos.Base.PointOfInterest;

namespace SearchAndRescue.POI.Dtos.Get
{
    public class PointOfInterest : PointOfInterestBase
    {
        public Guid Id { get; set; }
    }
}
