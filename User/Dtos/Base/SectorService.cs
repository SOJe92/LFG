using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Dtos.Base
{
    public class SectorService
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid SectorId { get; set; }

        public Guid ServiceId { get; set; }
    }
}
