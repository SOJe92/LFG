﻿using AutoMapper;
using SearchAndRescue.Admin.Contracts.Services;
using SearchAndRescue.User.Contracts.Services;
using IConfiguration = SearchAndRescue.User.Contracts.Services.IConfiguration;
using IRepo = SearchAndRescue.Admin.Contracts.Repositories.IAdmin;

namespace SearchAndRescue.Admin.Services
{
    public class Admin : IAdmin
    {
        private readonly IRepo _repo;
        private readonly IMapper _mapper;
        private readonly IConfiguration _userConfigurationService;

        public Admin(IRepo repo, IMapper mapper, IConfiguration userConfigurationService)
        {
            _repo = repo;
            _mapper = mapper;
            _userConfigurationService = userConfigurationService;
        }

        public async Task<Dtos.Get.User> GetUserAsync(Guid id)
        {
            Database.Models.User? result = await _repo.GetUserAsync(id);
            var user = _mapper.Map<Dtos.Get.User>(result);
            user.Configuration = await _userConfigurationService.GetAsync(id);
            return user;
        }

        public async Task<IEnumerable<Dtos.Get.User>> GetUsersAsync()
        {
            IEnumerable<Database.Models.User>? result = await _repo.GetUsersAsync();
            return _mapper.Map<IEnumerable<Dtos.Get.User>>(result);
        }
    }
}
