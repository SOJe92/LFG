using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Dtos.Base
{
    public class Entity
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid EntityId { get; set; }
    }
}
