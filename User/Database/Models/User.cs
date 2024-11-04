using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("account.users")]
    public record User : DbEntity
    {
        [Column("username")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Username { get; set; }

        [Column("email")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Email { get; set; }

        [Column("is_master")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public bool? IsAdmin { get; set; }

        public bool? IsEmailConfirmed { get; set; }

        [Column("last_login")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public DateTime? LastLogin { get; set; }

        [Column("addr1")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Addr1 { get; set; }

        [Column("addr2")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Addr2 { get; set; }

        [Column("city")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string City { get; set; }

        [Column("region")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Region { get; set; }

        [Column("postcode")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string PostalCode { get; set; }

        [Column("country")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Country { get; set; }

        [Column("locale")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Locale { get; set; }

        [Column("image")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Image { get; set; }

        [Column("location")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Location { get; set; }

        [Column("x")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public long X { get; set; }

        [Column("y")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public long Y { get; set; }
    }
}
