namespace SearchAndRescue.Keyword.Contracts.Services
{
    public interface IKeyword
    {
        Task<IEnumerable<Dtos.Get.Keyword>> GetKeywordsAsync();
        Task<Dtos.Get.Keyword> GetKeywordAsync(Dtos.Get.Keyword feature);
    }
}
