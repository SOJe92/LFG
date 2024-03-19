using SearchAndRescue.Entities.Dtos.Post;

namespace SearchAndRescue.Entities.Contracts.Repositories
{
    public interface IEntities
    {
        Task<Models.Entity> Get(Guid id);
        Task<IEnumerable<Models.Entity>> GetAll(Guid id);
        Task<int> Add(Entity entity);
        Task<int> Update(Dtos.Put.Entity entity);
        Task<int> Delete(Guid id);
    }
}
