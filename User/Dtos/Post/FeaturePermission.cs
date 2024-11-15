using FeaturePermissionBase = SearchAndRescue.User.Dtos.Base.FeaturePermission;
namespace SearchAndRescue.User.Dtos.Post
{
    public class FeaturePermission : FeaturePermissionBase
    {
        public Guid? Id { get; set; }
    }
}
