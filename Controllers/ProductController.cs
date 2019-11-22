using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Grocer.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProdList()
        {
            List<ProductDetails> Records = new List<ProductDetails>() {
                new ProductDetails(){ PID=1,Name="Apple",MRP=120},
                new ProductDetails(){ PID=2,Name="Orange",MRP=60},
                new ProductDetails(){ PID=3,Name="Grapes",MRP=80},
                new ProductDetails(){ PID=4,Name="Banana",MRP=30},
            };
            
            return View(Records);
        }
    }

    public class ProductDetails
    {
        public int PID { get; set; }
        public string Name { get; set; }
        public decimal MRP { get; set; }

    }
}