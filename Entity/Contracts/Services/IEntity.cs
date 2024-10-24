namespace SearchAndRescue.Entity.Contracts.Services
{
    public interface IEntity
    {
        Task<Dtos.Get.Entity> Get(Guid id);

        Task<int> Add(Dtos.Post.Entity entity);

        Task<bool> Update(Dtos.Put.Entity entity);

        Task<bool> Delete(Guid id);
    }
}
