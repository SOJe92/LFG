using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Dtos.Base
{
    public class Feature
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid FeatureId { get;set; }

        public bool Enabled { get; set; }
    }
}
