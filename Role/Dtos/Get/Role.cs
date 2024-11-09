using RoleBase = SearchAndRescue.Role.Dtos.Base.Role;

namespace SearchAndRescue.Role.Dtos.Get
{
    public class Role : RoleBase
    {
        public Guid Id { get; set; }
    }
}
