using System;
using System.Collections.Generic;

namespace Grocer.Models
{
    public partial class Delivery
    {
        public int DeliveryId { get; set; }
        public int OrderId { get; set; }
        public int EmployeeId { get; set; }
        public int AddressId { get; set; }
        public string DeliveryStatus { get; set; }
        public string PaymentStatus { get; set; }

        public Address Address { get; set; }
        public Employee Employee { get; set; }
        public ProductOrder Order { get; set; }
    }
}
