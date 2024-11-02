namespace SearchAndRescue.User.Contracts.Repositories
{
    public interface IUser
    {
        Task<Database.Models.User> Get(Database.Models.User login);

        Task<Database.Models.User> TryGet(Database.Models.User login);

        Task<int> Create(Database.Models.User registration);

        Task<IEnumerable<Database.Models.Feature>> GetFeaturePermissions(Guid userId);
    }
}
