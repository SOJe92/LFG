namespace SearchAndRescue.Entities.Contracts.Repositories
{
    public interface IEntities
    {
        Task<IEnumerable<Models.Entity>> Get(Guid id);
        Task<IEnumerable<Models.Entity>> Get();
    }
}
