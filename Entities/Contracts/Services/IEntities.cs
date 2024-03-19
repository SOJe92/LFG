using SearchAndRescue.Entities.Dtos.Get;

namespace SearchAndRescue.Entities.Contracts.Services
{
    public interface IEntities
    {
        Task<IEnumerable<Entity>> GetAll(Guid id);

        Task<Entity> Get(Guid id);

        Task<int> Add(Dtos.Post.Entity entity);

        Task<int> Update(Dtos.Put.Entity entity);

        Task<int> Delete(Guid id);
    }
}
