namespace SearchAndRescue.POI.Contracts.Services
{
    public interface IPointOfInterest
    {
        Task<IEnumerable<Dtos.Get.PointOfInterest>> GetPointOfInterestsAsync();
        Task<Dtos.Get.PointOfInterest> GetPointOfInterestAsync(Dtos.Get.PointOfInterest poi);
    }
}
