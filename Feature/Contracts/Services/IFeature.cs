namespace SearchAndRescue.Feature.Contracts.Services
{
    public interface IFeature
    {
        Task<IEnumerable<Dtos.Get.Feature>> GetFeaturesAsync();
        Task<Dtos.Get.Feature> GetFeatureAsync(Dtos.Get.Feature feature);
        Task<IEnumerable<Dtos.Get.FeaturePermission>> GetFeaturePermissionsAsync();
        Task<Dtos.Get.FeaturePermission> GetFeaturePermissionAsync(Dtos.Get.FeaturePermission feature);
    }
}
