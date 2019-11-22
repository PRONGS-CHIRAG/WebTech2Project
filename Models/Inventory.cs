using System;
using System.Collections.Generic;

namespace Grocer.Models
{
    public partial class Inventory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public short Stock { get; set; }

        public Product Product { get; set; }
    }
}
