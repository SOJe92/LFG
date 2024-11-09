using ServiceBase = SearchAndRescue.Sectors.Dtos.Base.Service;

namespace SearchAndRescue.Sectors.Dtos.Get
{
    public class Service : ServiceBase
    {
        public Guid Id { get; set; }
    }
}
