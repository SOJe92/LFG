using Newtonsoft.Json;

namespace SearchAndRescue.User.Dtos.Base
{
    public class ChildUser
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ChildUserId { get; set; }
    }
}
