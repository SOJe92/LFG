﻿using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.usersectorservices")]
    public record SectorService : DbEntity
    {
        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("sector_id")]
        public Guid SectorId { get; set; }

        [Column("service_id")]
        public Guid ServiceId { get; set; }
    }
}
