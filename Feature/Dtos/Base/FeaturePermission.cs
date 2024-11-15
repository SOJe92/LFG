namespace SearchAndRescue.Feature.Dtos.Base
{
    public class FeaturePermission
    {
        public Guid FeatureId { get; set; }

        public Guid PermissionId { get; set; }

        public bool Enabled { get; set; }
    }
}
