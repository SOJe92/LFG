﻿using AutoMapper;

namespace SearchAndRescue.Admin.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Get.User, Models.User>();
            CreateMap<Models.User, Dtos.Get.User>();


            CreateMap<Dtos.Put.User, Models.User>();
            CreateMap<Models.User, Dtos.Put.User>();
        }
    }
}
