﻿namespace Kumbajah.Domain.Entities
{
    public class Stock
    {
        public long Id { get; private set; }
        public virtual Product Product { get; }
        public int Quantity { get; private set; }

        public Stock() { }

        public Stock(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }
    }
}