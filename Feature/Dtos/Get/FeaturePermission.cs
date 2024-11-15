using FeaturePermissionBase = SearchAndRescue.Feature.Dtos.Base.FeaturePermission;
namespace SearchAndRescue.Feature.Dtos.Get
{
    public class FeaturePermission : FeaturePermissionBase
    {
        public Guid Id { get; set; }
    }
}
