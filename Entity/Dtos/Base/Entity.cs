﻿namespace SearchAndRescue.Entity.Dtos.Base
{
    public class Entity
    {
        public string? Name { get; set; }

        public string? Reg { get; set; }

        public string? Address1 { get; set; }

        public string? Address2 { get; set; }

        public string? City { get; set; }

        public string? Region { get; set; }

        public string? Postcode { get; set; }

        public string? Country { get; set; }

        public string? Phone { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; } = null;
    }
}
