namespace Kumbajah.Services.DTO
{
    public class OrderItemDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public OrderItemDTO() { }

        public decimal SubTotal()
        {
            return Price * Quantity;
        }

        public OrderItemDTO(int quantity, decimal price,
            int orderId, int productId)
        {
            Quantity = quantity;
            Price = price;
            OrderId = orderId;
            ProductId = productId;
        }
    }
}
