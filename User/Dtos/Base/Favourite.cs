namespace SearchAndRescue.User.Dtos.Base
{
    public class Favourite
    {


        public Guid? UserId { get; set; }

        public Guid? FavouriteId { get; set; }

        public Guid? ResourceId { get; set; }

        public Guid? TypeId { get; set; }
    }
}
