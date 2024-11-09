using Dapper;
using SearchAndRescue.ContactType.Contracts.Repositories;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Helpers;

namespace SearchAndRescue.ContactType.Repositories
{
    public class ContactType : IContactType
    {
        private readonly IDbService _dbService;

        public ContactType(IDbService dbService) => _dbService = dbService;
        public async Task<Database.Models.ContactType> GetContactTypeAsync(Database.Models.ContactType contactType)
        {
            PostgresDataAccess.BuildGetQuery(contactType, out string tableName, out string columns, out DynamicParameters parameters, "id");
            contactType = await _dbService.ExecuteQueryFirstAsync<Database.Models.ContactType>(Core.Database.Queries.Get(columns, tableName), parameters);

            return contactType;
        }

        public async Task<IEnumerable<Database.Models.ContactType>> GetContactTypesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.ContactType(), out string tableName, out string columns, out DynamicParameters parameters);
            var contactTypes = await _dbService.ExecuteQueryAsync<Database.Models.ContactType>(Core.Database.Queries.Get(columns, tableName), parameters);

            return contactTypes;
        }
    }
}
