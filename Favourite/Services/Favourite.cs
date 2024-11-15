using AutoMapper;
using SearchAndRescue.Favourite.Contracts.Services;
using SearchAndRescue.Favourite.Dtos.Get;
using IRepo = SearchAndRescue.Favourite.Contracts.Repositories.IFavourite;

namespace SearchAndRescue.Favourite.Services
{
    public class Favourite : IFavourite
    {
        private readonly IRepo _repo;
        private readonly IMapper _mapper;
        public Favourite(IRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Guid> AddEntityFavouriteAsync(Dtos.Post.UserFavourite userFavourite)
        {
            Database.Models.UserFavourite model = _mapper.Map<Database.Models.UserFavourite>(userFavourite);
            return await _repo.AddEntityFavouriteAsync(model);
        }

        public async Task<Guid> AddProductFavouriteAsync(Dtos.Post.UserFavourite userFavourite)
        {
            Database.Models.UserFavourite model = _mapper.Map<Database.Models.UserFavourite>(userFavourite);
            return await _repo.AddProductFavouriteAsync(model);
        }

        public async Task<bool> DeleteEntityFavouriteAsync(EntityFavourite entityFavourite)
        {
            Database.Models.UserFavourite model = _mapper.Map<Database.Models.UserFavourite>(entityFavourite);
            return await _repo.DeleteEntityFavouriteAsync(model);
        }

        public async Task<bool> DeleteProductFavouriteAsync(ProductFavourite productFavourite)
        {
            Database.Models.UserFavourite model = _mapper.Map<Database.Models.UserFavourite>(productFavourite);
            return await _repo.DeleteProductFavouriteAsync(model);
        }

        public async Task<Dtos.Get.EntityFavourite> GetEntityFavouriteAsync(Dtos.Get.EntityFavourite entityFavourite)
        {
            Database.Models.EntityFavourite? model = _mapper.Map<Database.Models.EntityFavourite>(entityFavourite);
            model = await _repo.GetEntityFavouriteAsync(model);
            return _mapper.Map<Dtos.Get.EntityFavourite>(model);
        }

        public async Task<IEnumerable<Dtos.Get.EntityFavourite>> GetEntityFavouritesAsync()
        {
            IEnumerable<Database.Models.EntityFavourite>? result = await _repo.GetEntityFavouritesAsync();
            return _mapper.Map<IEnumerable<Dtos.Get.EntityFavourite>>(result);
        }

        public async Task<IEnumerable<EntityFavourite>> GetEntityFavouritesAsync(EntityFavourite entityFavourite)
        {
            Database.Models.EntityFavourite? model = _mapper.Map<Database.Models.EntityFavourite>(entityFavourite);
            IEnumerable<Database.Models.EntityFavourite>? result = await _repo.GetEntityFavouritesAsync(model);
            return _mapper.Map<IEnumerable<Dtos.Get.EntityFavourite>>(result);
        }

        public async Task<Dtos.Get.FavouriteType> GetFavouriteTypeAsync(Dtos.Get.FavouriteType favouriteType)
        {
            Database.Models.FavouriteType? model = _mapper.Map<Database.Models.FavouriteType>(favouriteType);
            Database.Models.FavouriteType? result = await _repo.GetFavouriteTypeAsync(model);
            return _mapper.Map<Dtos.Get.FavouriteType>(result);
        }

        public IEnumerable<FavouriteType> GetFavouriteTypes()
        {
            IEnumerable<Database.Models.FavouriteType>? result = _repo.GetFavouriteTypes();
            return _mapper.Map<IEnumerable<Dtos.Get.FavouriteType>>(result);
        }

        public async Task<IEnumerable<Dtos.Get.FavouriteType>> GetFavouriteTypesAsync()
        {
            IEnumerable<Database.Models.EntityFavourite>? result = await _repo.GetEntityFavouritesAsync();
            return _mapper.Map<IEnumerable<Dtos.Get.FavouriteType>>(result);
        }

        public async Task<ProductFavourite> GetProductFavouriteAsync(ProductFavourite productFavourite)
        {
            Database.Models.ProductFavourite? model = _mapper.Map<Database.Models.ProductFavourite>(productFavourite);
            Database.Models.ProductFavourite? result = await _repo.GetProductFavouriteAsync(model);
            return _mapper.Map<Dtos.Get.ProductFavourite>(result);
        }

        public async Task<IEnumerable<Dtos.Get.ProductFavourite>> GetProductFavouritesAsync()
        {
            IEnumerable<Database.Models.ProductFavourite>? result = await _repo.GetProductFavouritesAsync();
            return _mapper.Map<IEnumerable<Dtos.Get.ProductFavourite>>(result);
        }

        public async Task<IEnumerable<ProductFavourite>> GetProductFavouritesAsync(ProductFavourite productFavourite)
        {
            Database.Models.ProductFavourite? model = _mapper.Map<Database.Models.ProductFavourite>(productFavourite);
            IEnumerable<Database.Models.ProductFavourite>? result = await _repo.GetProductFavouritesAsync(model);
            return _mapper.Map<IEnumerable<Dtos.Get.ProductFavourite>>(result);
        }
    }
}
