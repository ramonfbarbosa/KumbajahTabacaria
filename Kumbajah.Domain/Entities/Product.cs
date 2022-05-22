namespace Kumbajah.Domain.Entities
{
    public class Product : Base
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string Image { get; private set; }
        public long Quantity { get; private set; }
        public virtual Category Category { get; private set; }
        public int CategoryId { get; private set; }

        public Product() { }

        public Product(string name, string description, decimal price, string image, long quantity, Category category)
        {
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            Quantity = quantity;
            Category = category;
        }
    }
}
