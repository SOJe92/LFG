namespace SearchAndRescue.Feature.Contracts.Repositories
{
    public interface IFeature
    {
        Task<IEnumerable<Database.Models.Feature>> GetFeaturesAsync();
        Task<Database.Models.Feature> GetFeatureAsync(Database.Models.Feature feature);
    }
}
