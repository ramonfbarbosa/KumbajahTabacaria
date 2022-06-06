namespace Kumbajah.Domain.Entities
{
    public class OrderItem
    {
        public long Id { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public virtual Order Order { get; private set; }
        public long OrderId { get; private set; }
        public virtual Product Product { get; private set; }
        public long ProductId { get; private set; }

        public OrderItem() { }

        public OrderItem(int quantity, decimal price,
            long orderId, long productId)
        {
            Quantity = quantity;
            Price = price;
            OrderId = orderId;
            ProductId = productId;
        }
    }
}
