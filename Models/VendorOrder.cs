using System;
using System.Collections.Generic;

namespace Grocer.Models
{
    public partial class VendorOrder
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int VendorId { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }

        public ProductOrder Order { get; set; }
        public Vendor Vendor { get; set; }
    }
}
