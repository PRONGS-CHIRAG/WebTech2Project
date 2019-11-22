using System;
using System.Collections.Generic;

namespace Grocer.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Delivery = new HashSet<Delivery>();
            Queries = new HashSet<Queries>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePosition { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public ICollection<Delivery> Delivery { get; set; }
        public ICollection<Queries> Queries { get; set; }
    }
}
