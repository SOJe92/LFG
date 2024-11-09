namespace SearchAndRescue.Sectors.Contracts.Services
{
    public interface ISector
    {
        Task<IEnumerable<Dtos.Get.Sector>> GetSectorsAsync();
        Task<Dtos.Get.Sector> GetSectorAsync(Dtos.Get.Sector feature);
        Task<IEnumerable<Dtos.Get.Service>> GetServicesAsync();
        Task<Dtos.Get.Service> GetServiceAsync(Dtos.Get.Service feature);
        Task<IEnumerable<Dtos.Get.SectorService>> GetSectorServicesAsync();
        Task<Dtos.Get.SectorService> GetSectorServiceAsync(Dtos.Get.SectorService feature);
    }
}
