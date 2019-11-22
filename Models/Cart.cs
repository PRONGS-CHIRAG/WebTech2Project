using System;
using System.Collections.Generic;

namespace Grocer.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public ProductOrder Order { get; set; }
        public Product Product { get; set; }
    }
}
