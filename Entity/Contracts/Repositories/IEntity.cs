namespace SearchAndRescue.Entity.Contracts.Repositories
{
    public interface IEntity
    {
        Task<Database.Models.Entity> Get(Guid id);
        Task<int> Add(Database.Models.Entity entity);
        Task<bool> Update(Database.Models.Entity entity);
        Task<bool> Delete(Guid id);
    }
}
