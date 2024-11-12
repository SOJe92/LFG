using FeatureBase = SearchAndRescue.User.Dtos.Base.FeaturePermission;

namespace SearchAndRescue.User.Dtos.Get
{
    public class Feature : FeatureBase
    {
        public Guid Id { get; set; }
    }
}
