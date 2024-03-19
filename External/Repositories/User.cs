using AutoMapper;
using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.External.Contracts.Repositories;
using SearchAndRescue.External.Database;
using SearchAndRescue.External.Dtos.Get;
using SearchAndRescue.External.Dtos.Post;
using SearchAndRescue.Helpers;

namespace SearchAndRescue.External.Repositories
{
    public class User : IUser
    {
        private readonly IMapper _mapper;
        private readonly IDbService _dbService;

        public User(IMapper mapper, IDbService dbService)
        {
            _mapper = mapper;
            _dbService = dbService;
        }
    }
}
