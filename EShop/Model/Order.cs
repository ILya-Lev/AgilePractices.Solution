using System;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Model
{
    public class Order
    {
        public DateTime Date { get; set; }
        public Status Status { get; set; }
        public List<Item> Items { get; } = new List<Item>();
        public decimal Total => Items.Sum(item => item.Quantity * item.Product.Price);

        public void AddItem(Product product, int amount)
        {
            var item = new Item() { Product = product, Quantity = amount };
            Items.Add(item);
        }
    }

    public enum Status
    {
        Composing,
        Posted,
        Queued,
        Completed,
        Canceled
    }
}