﻿using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Helpers;
using SearchAndRescue.User.Contracts.Repositories;
using SearchAndRescue.User.Database;

namespace SearchAndRescue.User.Repositories
{
    public class User : IUser
    {
        private readonly IDbService _dbService;

        public User(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<Database.Models.User> TryGet(Database.Models.User login)
        {
            PostgresDataAccess.BuildParams(login, out DynamicParameters parameters);
            var result = await _dbService.ExecuteProcedureAsync(Queries.TrySignin, parameters);
            login.Id = result.Get<Guid>("id");

            return login;
        }

        public async Task<Database.Models.User> Get(Database.Models.User login)
        {
            PostgresDataAccess.BuildQuery<Database.Models.User>(out string tableName, out string columnNames);
            string query = $"SELECT {columnNames} FROM {tableName}",
                    filter = $"WHERE password=@password AND {(login.Username != null ? "username=@username" : "email=@email")}";

            var result = await _dbService.GetAsync<Database.Models.User>($"{query} {filter}", login);

            return result;
        }

        public async Task<int> Create(Database.Models.User registration)
        {
            string query = "";

            return await _dbService.SetData(query, registration);
        }
        public async Task<IEnumerable<Database.Models.Feature>> GetFeaturePermissions(Guid userId)
        {
            PostgresDataAccess.BuildQuery<Database.Models.Feature>(out _, out string columnNames);
            var param = new DynamicParameters();
            param.Add("puserid", userId);

            var result = await _dbService.ExecuteQueryAsync<Database.Models.Feature>(Queries.Permissions("*"), param);

            return result;
        }
    }
}
