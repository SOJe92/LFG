namespace SearchAndRescue.Admin.Dtos.Base
{
    public class User
    {
        public User()
        {
            Configuration = new();
        }

        public string Username { get; set; }

        public string Email { get; set; }

        public SearchAndRescue.User.Dtos.Get.Configuration Configuration { get; set; }
    }
}
