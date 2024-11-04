using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Dtos.Base
{
    public class Permission
    {
        public Guid Id { get; set; }

        public string Key { get; set; }

        public string Description { get; set; }
    }
}
