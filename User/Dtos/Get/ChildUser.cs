using ChildUserBase = SearchAndRescue.User.Dtos.Base.ChildUser;
namespace SearchAndRescue.User.Dtos.Get
{
    public class ChildUser : ChildUserBase
    {
        public Guid Id { get; set; }
    }
}
