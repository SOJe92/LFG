using ContactTypeBase = SearchAndRescue.ContactType.Dtos.Base.ContactType;
namespace SearchAndRescue.ContactType.Dtos.Get
{
    public class ContactType : ContactTypeBase
    {
        public Guid Id { get; set; }
    }
}
