using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Dtos.Base
{
    public class PointOfInterest
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid PointOfInterestId { get; set; }
    }
}
