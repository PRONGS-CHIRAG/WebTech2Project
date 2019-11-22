using System;
using System.Collections.Generic;

namespace Grocer.Models
{
    public partial class Product
    {
        public Product()
        {
            Bill = new HashSet<Bill>();
            Cart = new HashSet<Cart>();
            Inventory = new HashSet<Inventory>();
            ProductOrder = new HashSet<ProductOrder>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string ProductDescription { get; set; }

        public ICollection<Bill> Bill { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        public ICollection<ProductOrder> ProductOrder { get; set; }
    }
}
