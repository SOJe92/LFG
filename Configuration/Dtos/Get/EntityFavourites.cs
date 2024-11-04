using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Dtos.Get
{
    public class EntityFavourites
    {
        public Guid Id { get; set; }

        public Guid EntityId { get; set; }
    }
}
