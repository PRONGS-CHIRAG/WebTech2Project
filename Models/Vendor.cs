using System;
using System.Collections.Generic;

namespace Grocer.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            VendorOrder = new HashSet<VendorOrder>();
        }

        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }

        public ICollection<VendorOrder> VendorOrder { get; set; }
    }
}
