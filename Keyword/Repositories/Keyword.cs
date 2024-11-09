using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Helpers;
using SearchAndRescue.Keyword.Contracts.Repositories;

namespace SearchAndRescue.Keyword.Repositories
{
    public class Keyword : IKeyword
    {
        private readonly IDbService _dbService;

        public Keyword(IDbService dbService) => _dbService = dbService;
        public async Task<Database.Models.Keyword> GetKeywordAsync(Database.Models.Keyword keyword)
        {
            PostgresDataAccess.BuildGetQuery(keyword, out string tableName, out string columns, out DynamicParameters parameters, "id");
            keyword = await _dbService.ExecuteQueryFirstAsync<Database.Models.Keyword>(Core.Database.Queries.Get(columns, tableName), parameters);

            return keyword;
        }

        public async Task<IEnumerable<Database.Models.Keyword>> GetKeywordsAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.Keyword(), out string tableName, out string columns, out DynamicParameters parameters);
            var features = await _dbService.ExecuteQueryAsync<Database.Models.Keyword>(Core.Database.Queries.Get(columns, tableName), parameters);

            return features;
        }
    }
}
