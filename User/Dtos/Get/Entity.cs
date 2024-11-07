using EntityBase = SearchAndRescue.User.Dtos.Base.Entity;

namespace SearchAndRescue.User.Dtos.Get
{
    public class Entity : EntityBase
    {
        public Guid Id { get; set; }
    }
}
