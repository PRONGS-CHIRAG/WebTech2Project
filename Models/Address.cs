using System;
using System.Collections.Generic;

namespace Grocer.Models
{
    public partial class Address
    {
        public Address()
        {
            Delivery = new HashSet<Delivery>();
        }

        public int AddressId { get; set; }
        public int CustomerId { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Customer Customer { get; set; }
        public ICollection<Delivery> Delivery { get; set; }
    }
}
