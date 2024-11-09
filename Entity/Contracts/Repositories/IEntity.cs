namespace SearchAndRescue.Entity.Contracts.Repositories
{
    public interface IEntity
    {
        Task<Database.Models.Entity> GetAsync(Guid id);
        Task<int> AddAsync(Database.Models.Entity entity);
        Task<bool> UpdateAsync(Database.Models.Entity entity);
        Task<bool> DeleteAsync(Guid id);
        Task<IEnumerable<Database.Models.EntityType>> GetEntityTypesAsync();
        Task<Database.Models.EntityType> GetEntityTypeAsync(Database.Models.EntityType entityType);
    }
}
