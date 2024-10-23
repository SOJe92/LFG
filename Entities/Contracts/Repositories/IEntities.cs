using SearchAndRescue.Entities.Dtos.Post;

namespace SearchAndRescue.Entities.Contracts.Repositories
{
    public interface IEntities
    {
        Task<Models.Entity> Get(Guid id);
        Task<IEnumerable<Models.Entity>> GetAll(Guid id);
        Task<int> Add(Entity entity);
        Task<bool> Update(Dtos.Put.Entity entity);
        Task<bool> Delete(Guid id);
    }
}
