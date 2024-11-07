using ConfigurationBase = SearchAndRescue.User.Dtos.Base.Configuration;

namespace SearchAndRescue.User.Dtos.Get
{
    public class Configuration : ConfigurationBase
    {
        public Guid Id { get; set; }
    }
}
