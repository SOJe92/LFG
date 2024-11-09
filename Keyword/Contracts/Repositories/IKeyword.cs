namespace SearchAndRescue.Keyword.Contracts.Repositories
{
    public interface IKeyword
    {
        Task<IEnumerable<Database.Models.Keyword>> GetKeywordsAsync();
        Task<Database.Models.Keyword> GetKeywordAsync(Database.Models.Keyword keyword);
    }
}
