using ContactTypeBase = SearchAndRescue.User.Dtos.Base.ContactType;

namespace SearchAndRescue.User.Dtos.Get
{
    public class ContactType : ContactTypeBase
    {
        public Guid Id { get; set; }
    }
}
