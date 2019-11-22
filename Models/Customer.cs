using System;
using System.Collections.Generic;

namespace Grocer.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Address = new HashSet<Address>();
            Bill = new HashSet<Bill>();
            ProductOrder = new HashSet<ProductOrder>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }

        public ICollection<Address> Address { get; set; }
        public ICollection<Bill> Bill { get; set; }
        public ICollection<ProductOrder> ProductOrder { get; set; }
    }
}
