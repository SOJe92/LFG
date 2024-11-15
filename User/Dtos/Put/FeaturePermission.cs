using FeaturePermissionBase = SearchAndRescue.User.Dtos.Base.FeaturePermission;
namespace SearchAndRescue.User.Dtos.Put
{
    public class FeaturePermission : FeaturePermissionBase
    {
        public Guid? Id { get; set; }
    }
}
