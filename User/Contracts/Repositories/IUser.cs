namespace SearchAndRescue.User.Contracts.Repositories
{
    public interface IUser
    {
        Task<Models.User> Get(Models.User login);

        Task<Models.User> TryGet(Models.User login);

        Task<int> Create(Models.User registration);

        Task<IEnumerable<Models.Feature>> GetFeaturePermissions(Guid userId);
    }
}
