using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Entity.Models
{
    [Table("private.entity")]
    public class Entity
    {
        [Column("id")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.InputOutput)]
        public Guid? Id { get; set; }

        [Column("name")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.Input)]
        public string Name { get; set; }

        [Column("registration")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.Input)]
        public string Reg { get; set; }

        [Column("addr1")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.Input)]
        public string Address1 { get; set; }

        [Column("addr2")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.Input)]
        public string Address2 { get; set; }

        [Column("city")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.Input)]
        public string City { get; set; }

        [Column("region")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.Input)]
        public string Region { get; set; }

        [Column("postcode")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.Input)]
        public string Postcode { get; set; }

        [Column("country")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.Input)]
        public string Country { get; set; }

        [Column("phone")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.Input)]
        public string Phone { get; set; }

        [Column("description")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.Input)]
        public string Description { get; set; }

        [Column("image")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.Input)]
        public string Image { get; set; }

        [Column("sector_id")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.Input)]
        public Guid SectorId { get; set; }

        [Column("user_id")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.Input)]
        public Guid UserId { get; set; }
    }
}
