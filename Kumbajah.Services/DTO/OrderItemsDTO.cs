using Kumbajah.Domain.Entities;

namespace Kumbajah.Services.DTO
{
    public class OrderItemsDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public decimal SubTotal()
        {
            return Price * Quantity;
        }

        public OrderItemsDTO() { }

        public OrderItemsDTO(
            int id, int quantity, 
            decimal price, int orderId, int productId)
        {
            Id = id;
            Quantity = quantity;
            Price = price;
            OrderId = orderId;
            ProductId = productId;
        }

        public OrderItem GetEntity()
        {
            return new OrderItem
            {
                Id = Id,
                Quantity = Quantity,
                Price = Price,
                OrderId = OrderId,
                ProductId = ProductId
            };
        }
    }
}
