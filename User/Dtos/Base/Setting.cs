namespace SearchAndRescue.User.Dtos.Base
{
    public class Setting
    {
        public Guid Id { get; set; }

        public long LocationX { get; set; }

        public long LocationY { get; set; }

        public int[] Budget { get; set; }
    }
}
