namespace SearchAndRescue.Entities.Contracts.Repositories
{
    public interface IEntities
    {
        Task<IEnumerable<Models.Entities>> Get(Guid id);
        Task<IEnumerable<Models.Entities>> Get();
    }
}
