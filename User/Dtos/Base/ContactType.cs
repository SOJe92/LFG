using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Dtos.Base
{
    public class ContactType
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid ContactTypeId { get; set; }
    }
}
