using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Models
{
    [Table("account.users")]
    public record User
    {
        [Column("id")]
        [Key]
        [DapperParamDirection(System.Data.ParameterDirection.Output)]

        public Guid Id { get; set; }

        [Column("username")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Username { get; set; }

        [Column("email")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Email { get; set; }

        public string? PasswordSalt { get; set; } = null;
    }
}
