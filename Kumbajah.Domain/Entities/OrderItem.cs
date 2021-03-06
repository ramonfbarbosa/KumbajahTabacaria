namespace Kumbajah.Domain.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Order Order { get; set; }
        public int OrderId { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }

        public OrderItem() { }

        public OrderItem(
            int quantity, decimal price,
            int orderId, int productId)
        {
            Quantity = quantity;
            Price = price;
            OrderId = orderId;
            ProductId = productId;
        }
    }
}
