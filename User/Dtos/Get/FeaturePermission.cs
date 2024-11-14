using FeaturePermissionBase = SearchAndRescue.User.Dtos.Base.FeaturePermission;
namespace SearchAndRescue.User.Dtos.Get
{
    public class FeaturePermission : FeaturePermissionBase
    {
        public Guid? Id { get; set; }
    }
}
