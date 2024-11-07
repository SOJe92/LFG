using SectorServiceBase = SearchAndRescue.User.Dtos.Base.SectorService;

namespace SearchAndRescue.User.Dtos.Get
{
    public class SectorService : SectorServiceBase
    {
        public Guid Id { get; set; }
    }
}
