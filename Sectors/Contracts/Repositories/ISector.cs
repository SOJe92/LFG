namespace SearchAndRescue.Sectors.Contracts.Repositories
{
    public interface ISector
    {
        Task<IEnumerable<Database.Models.Sector>> GetSectorsAsync();
        Task<IEnumerable<Database.Models.Service>> GetServicesAsync();
        Task<IEnumerable<Database.Models.SectorService>> GetSectorServicesAsync();
        Task<Database.Models.Sector> GetSectorAsync(Database.Models.Sector sector);
        Task<Database.Models.Service> GetServiceAsync(Database.Models.Service service);
        Task<Database.Models.SectorService> GetSectorServiceAsync(Database.Models.SectorService sectorService);
    }
}
