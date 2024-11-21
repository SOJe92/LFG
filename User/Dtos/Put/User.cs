using UserBase = SearchAndRescue.User.Dtos.Base.User;

namespace SearchAndRescue.User.Dtos.Put
{
    public class User : UserBase
    {
        public User()
        {
            Configuration = new();
        }

        public Guid Id { get; set; }

        public Configuration? Configuration { get; set; }
    }
}
