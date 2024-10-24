namespace SearchAndRescue.Entities.Contracts.Services
{
    public interface IEntities
    {
        Task<IEnumerable<Dtos.Get.Entity>> Get(Guid id);
        Task<IEnumerable<Dtos.Get.Entity>> GetAll();
    }
}
