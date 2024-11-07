using RoleBase = SearchAndRescue.User.Dtos.Base.Role;

namespace SearchAndRescue.User.Dtos.Get
{
    public class Role : RoleBase
    {
        public Guid Id { get; set; }
    }
}
