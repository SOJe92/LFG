namespace SearchAndRescue.Entities.Contracts.Repositories
{
    public interface IEntities
    {
        Task<IEnumerable<Database.Models.Entities>> Get(Guid id);
        Task<IEnumerable<Database.Models.Entities>> Get();
    }
}
