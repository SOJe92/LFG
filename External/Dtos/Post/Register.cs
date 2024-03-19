namespace SearchAndRescue.External.Dtos.Post
{
    public class Register : Base.User
    {
        public string? FirstName { get; set; } = null;

        public string? LastName { get; set; } = null;

        public string? Address1 { get; set; } = null;

        public string? Address2 { get; set; } = null;

        public string? City { get; set; } = null;

        public string? Region { get; set; } = null;

        public string? PostalCode { get; set; } = null;

        public string? Country { get; set; } = null;

        public string? Phone { get; set; } = null;
    }
}
