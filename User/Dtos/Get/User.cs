﻿using Newtonsoft.Json;
using UserBase = SearchAndRescue.User.Dtos.Base.User;

namespace SearchAndRescue.User.Dtos.Get
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class User : UserBase
    {
        public User()
        {
            Configuration = new();
        }
        
        public Guid Id { get; set; }

        public Configuration? Configuration { get; set; }
    }
}
