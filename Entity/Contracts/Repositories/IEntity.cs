namespace SearchAndRescue.Entity.Contracts.Repositories
{
    public interface IEntity
    {
        Task<Models.Entity> Get(Guid id);
        Task<int> Add(Dtos.Post.Entity entity);
        Task<bool> Update(Dtos.Put.Entity entity);
        Task<bool> Delete(Guid id);
    }
}
