namespace SearchAndRescue.ContactType.Contracts.Repositories
{
    public interface IContactType
    {
        Task<IEnumerable<Database.Models.ContactType>> GetContactTypesAsync();
        Task<Database.Models.ContactType> GetContactTypeAsync(Database.Models.ContactType contactType);
    }
}
