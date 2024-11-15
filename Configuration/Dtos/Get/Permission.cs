using PermissionBase = SearchAndRescue.Configuration.Dtos.Base.Permission;
namespace SearchAndRescue.Configuration.Dtos.Get
{
    public class Permission : PermissionBase
    {
        public Guid Id { get; set; }
    }
}
