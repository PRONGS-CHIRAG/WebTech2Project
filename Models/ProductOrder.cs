using System;
using System.Collections.Generic;

namespace Grocer.Models
{
    public partial class ProductOrder
    {
        public ProductOrder()
        {
            Bill = new HashSet<Bill>();
            Cart = new HashSet<Cart>();
            Delivery = new HashSet<Delivery>();
            Queries = new HashSet<Queries>();
            VendorOrder = new HashSet<VendorOrder>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string OrderStatus { get; set; }
        public string OrderPaymentStatus { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public ICollection<Bill> Bill { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<Delivery> Delivery { get; set; }
        public ICollection<Queries> Queries { get; set; }
        public ICollection<VendorOrder> VendorOrder { get; set; }
    }
}
