using PointOfInterestBase = SearchAndRescue.User.Dtos.Base.PointOfInterest;

namespace SearchAndRescue.User.Dtos.Get
{
    public class PointOfInterest : PointOfInterestBase
    {
        public Guid Id { get; set; }
    }
}
