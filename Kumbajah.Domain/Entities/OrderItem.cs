using System.ComponentModel.DataAnnotations.Schema;

namespace Kumbajah.Domain.Entities
{
    public class OrderItem
    {
        public int Id { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public virtual Order Order { get; private set; }
        [Column("ORDER_ID")]
        public int OrderId { get; private set; }
        public virtual Product Product { get; private set; }
        [Column("PRODUCT_ID")]
        public int ProductId { get; private set; }

        public OrderItem() { }

        public decimal SubTotal()
        {
            return Price * Quantity;
        }

        public OrderItem(int quantity, decimal price,
            int orderId, int productId)
        {
            Quantity = quantity;
            Price = price;
            OrderId = orderId;
            ProductId = productId;
        }
    }
}
