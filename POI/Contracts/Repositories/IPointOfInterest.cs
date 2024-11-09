namespace SearchAndRescue.POI.Contracts.Repositories
{
    public interface IPointOfInterest
    {
        Task<IEnumerable<Database.Models.PointOfInterest>> GetPointOfInterestsAsync();
        Task<Database.Models.PointOfInterest> GetPointOfInterestAsync(Database.Models.PointOfInterest poi);
    }
}
