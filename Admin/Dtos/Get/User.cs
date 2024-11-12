using UserBase = SearchAndRescue.Admin.Dtos.Base.User;

namespace SearchAndRescue.Admin.Dtos.Get
{
    public class User : UserBase
    {
        public Guid Id { get; set; }
    }
}
