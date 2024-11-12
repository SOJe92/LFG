namespace SearchAndRescue.User.Dtos.Base
{
    public class FeaturePermission
    {


        public Guid? UserId { get; set; }

        public Guid? FeatureId { get; set; }

        public Guid? PermissionId { get; set; }

        public bool? Enabled { get; set; }
    }
}
