namespace SearchAndRescue.ContactType.Contracts.Services
{
    public interface IContactType
    {
        Task<IEnumerable<Dtos.Get.ContactType>> GetContactTypesAsync();
        Task<Dtos.Get.ContactType> GetContactTypeAsync(Dtos.Get.ContactType contactType);
    }
}
