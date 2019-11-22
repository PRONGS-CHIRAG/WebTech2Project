using System;
using System.Collections.Generic;

namespace Grocer.Models
{
    public partial class Queries
    {
        public int QueryId { get; set; }
        public int OrderId { get; set; }
        public int EmployeeId { get; set; }
        public string Cquery { get; set; }
        public string Qstatus { get; set; }

        public Employee Employee { get; set; }
        public ProductOrder Order { get; set; }
    }
}
