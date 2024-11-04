using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Dtos.Get
{
    public class Feature
    {
        public Guid Id { get; set; }

        public string Key { get; set; }

        public string Description { get; set; }

        public bool Enabled { get; set; }
    }
}
