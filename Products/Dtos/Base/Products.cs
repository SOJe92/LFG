namespace SearchAndRescue.Products.Dtos.Base
{
    public abstract class Products
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }

        public float? Cost { get; set; }

        public long? X { get; set; }

        public long? Y { get; set; }

        public long? Timestamp { get; set; }
    }
}
