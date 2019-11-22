﻿using System;
using System.Collections.Generic;

namespace Grocer.Models
{
    public partial class Bill
    {
        public int BillId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public string CustomerName { get; set; }
        public double TotalPrice { get; set; }

        public Customer Customer { get; set; }
        public ProductOrder Order { get; set; }
        public Product Product { get; set; }
    }
}
