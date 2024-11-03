﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userfeatures")]
    public class Feature
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("feature_id")]
        public Guid FeatureId { get;set; }

        [Column("enabled")]
        public bool Enabled { get; set; }
    }
}
