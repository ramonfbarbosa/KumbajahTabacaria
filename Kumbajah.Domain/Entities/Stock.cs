namespace Kumbajah.Domain.Entities
{
    public class Stock
    {
        public int Id { get; private set; }
        public int Quantity { get; private set; }
        public virtual Product Product { get; }

        public Stock() { }

        public Stock(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }
    }
}
