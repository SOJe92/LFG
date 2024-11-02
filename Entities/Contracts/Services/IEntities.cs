namespace SearchAndRescue.Entities.Contracts.Services
{
    public interface IEntities
    {
        Task<IEnumerable<Dtos.Get.Entities>> Get(Guid id);
        Task<IEnumerable<Dtos.Get.Entities>> Get();
    }
}
