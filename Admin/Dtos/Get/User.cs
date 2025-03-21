﻿using UserBase = SearchAndRescue.Admin.Dtos.Base.User;

namespace SearchAndRescue.Admin.Dtos.Get
{
    public class User : UserBase
    {
        public User()
        {
            Configuration = new();
        }

        public Guid Id { get; set; }

        public SearchAndRescue.User.Dtos.Get.Configuration Configuration { get; set; }
    }
}
