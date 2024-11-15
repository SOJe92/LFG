using UserBase = SearchAndRescue.Admin.Dtos.Base.User;

namespace SearchAndRescue.Admin.Dtos.Put
{
    public class User : UserBase
    {
        public User()
        {
            Configuration = new();
        }
        public Guid Id { get; set; }

        public SearchAndRescue.User.Dtos.Put.Configuration? Configuration { get; set; }
    }
}
