namespace SearchAndRescue.Entity.Contracts.Services
{
    public interface IEntity
    {
        Task<Dtos.Get.Entity> GetAsync(Guid id);

        Task<int> AddAsync(Dtos.Post.Entity entity);

        Task<bool> UpdateAsync(Dtos.Put.Entity entity);

        Task<bool> DeleteAsync(Guid id);
        Task<IEnumerable<Dtos.Get.EntityType>> GetEntityTypesAsync();
        Task<Dtos.Get.EntityType> GetEntityTypeAsync(Dtos.Get.EntityType entityType);
    }
}
