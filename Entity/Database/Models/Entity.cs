using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Entity.Database.Models
{
    [Table("private.entity")]
    public class Entity
    {
        [Column("id")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public Guid? Id { get; set; }

        [Column("name")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Name { get; set; }

        [Column("registration")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Reg { get; set; }

        [Column("addr1")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Address1 { get; set; }

        [Column("addr2")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Address2 { get; set; }

        [Column("city")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string City { get; set; }

        [Column("region")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Region { get; set; }

        [Column("postcode")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Postcode { get; set; }

        [Column("country")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Country { get; set; }

        [Column("phone")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Phone { get; set; }

        [Column("description")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Description { get; set; }

        [Column("image")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Image { get; set; }

        [Column("sector_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid SectorId { get; set; }

        [Column("user_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid UserId { get; set; }
    }
}
