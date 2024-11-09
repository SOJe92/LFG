using EntityTypeBase = SearchAndRescue.Entity.Dtos.Base.EntityType;
namespace SearchAndRescue.Entity.Dtos.Get
{
    public class EntityType : EntityTypeBase
    {
        public Guid Id { get; set; }
    }
}
