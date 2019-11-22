using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Grocer.Models;
using System.Text.RegularExpressions;


namespace Grocer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Customer()
        {
            return View();
        }
        public IActionResult Employee()
        {
            return View();
        }
        public IActionResult Vendor()
        {
            return View();
        }
        public IActionResult AddVendor()
        {

            Vendor e = new Vendor();
            firstappContext d = new firstappContext();
            e.VendorName = HttpContext.Request.Form["cname"].ToString();
            e.PhoneNumber = Convert.ToInt64(HttpContext.Request.Form["phone"]);
            e.Email = HttpContext.Request.Form["email"].ToString();
            e.JoinDate = Convert.ToDateTime(HttpContext.Request.Form["Date"]);
            var regex = new Regex(@"[0-9]{10}");
            var regex1 = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var regex2 = new Regex(@"^[a-zA-Z]+$");
            if (regex.IsMatch(e.PhoneNumber.ToString()) && regex1.IsMatch(e.Email) && regex2.IsMatch(e.VendorName))
            {
                d.Vendor.Add(e);
                d.SaveChanges();
                ViewData["Message"] = "Successfully added";
            }
            else
            {
                ViewData["Message"] = "Enter correctly";
            }
            
            return View();
        }
        public IActionResult AddEmployee()
        {
            Employee e = new Employee();
            firstappContext d = new firstappContext();
            e.EmployeeName = HttpContext.Request.Form["cname"].ToString();
            e.EmployeePosition = HttpContext.Request.Form["Position"].ToString();
            e.PhoneNumber = Convert.ToInt32(HttpContext.Request.Form["phone"]);
            e.Email = HttpContext.Request.Form["email"].ToString();
            e.Salary = Convert.ToDouble(HttpContext.Request.Form["Salary"]);
            var regex = new Regex(@"[0-9]{10}");
            var regex1 = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var regex2 = new Regex(@"^[a-zA-Z]+$");
            if (regex.IsMatch(e.PhoneNumber.ToString()) && regex1.IsMatch(e.Email) && regex2.IsMatch(e.EmployeeName))
            {
                d.Employee.Add(e);
                d.SaveChanges();
                ViewData["Message"] = "Successfully added";
            }
            else
            {
                ViewData["Message"] = "Enter correctly";
            }
            return View();
        }
        
        public IActionResult AddProduct()
        {
            Product p = new Product();
            firstappContext c = new firstappContext();
            string pname= HttpContext.Request.Form["pname"].ToString();
            p.ProductName = HttpContext.Request.Form["pname"].ToString();
            p.Price = Convert.ToDouble(HttpContext.Request.Form["price"]);
            p.ProductDescription = HttpContext.Request.Form["Description"].ToString();
            
            p.Category = HttpContext.Request.Form["Category"].ToString();
            c.Add(p);
            c.SaveChanges();
            Inventory d = new Inventory();
            var Pid = Convert.ToInt32((from s in c.Product where s.ProductName == pname select s.ProductId).FirstOrDefault());
            d.Quantity = 10;
            d.Stock = 1;
            d.ProductId = Pid;
            c.Add(d);
            c.SaveChanges();
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult Contact()
        {
            Customer a = new Customer();
            Address c = new Address();
            firstappContext b = new firstappContext();
            a.CustomerName = HttpContext.Request.Form["cname"].ToString();
            ViewData["customer"] = a.CustomerName;
            a.PhoneNumber = Convert.ToInt64(HttpContext.Request.Form["phone"]);
            a.Email = HttpContext.Request.Form["email"].ToString();
            a.JoinDate = Convert.ToDateTime(HttpContext.Request.Form["Date"]);
            var regex = new Regex(@"[0-9]{10}");
            var regex1 = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var regex2 = new Regex(@"^[a-zA-Z]+$");
            if (regex.IsMatch(a.PhoneNumber.ToString())  && regex1.IsMatch(a.Email) && regex2.IsMatch(a.CustomerName))
            {
                b.Customer.Add(a);
                b.SaveChanges();
                ViewData["Message"]= "Successfully added";
            }
            else
            {
                ViewData["Message"] = "Enter correctly";
            }
            var  cus = Convert.ToInt32((from s in b.Customer where (s.CustomerName == a.CustomerName && s.PhoneNumber ==a.PhoneNumber)  select s.CustomerId).FirstOrDefault());
            //get the last record inserted id 
            c.CustomerId =cus;
            c.City = HttpContext.Request.Form["city"].ToString();
            c.State = HttpContext.Request.Form["state"].ToString();
            c.Address1 = HttpContext.Request.Form["address"].ToString();
            b.Address.Add(c);
            b.SaveChanges();
            ViewData["Message"] = "Successfully added";
            return View();
        }
        public IActionResult Order()
        {
            return View();
        }
        public IActionResult AddOrder()
        {
            Customer a = new Customer();
            Product b = new Product();
            ProductOrder c = new ProductOrder();
            Bill e = new Bill();
            Cart f = new Cart();
            Delivery g = new Delivery();
            string CustomerName = HttpContext.Request.Form["cname"].ToString();
            string ProductName = HttpContext.Request.Form["pname"].ToString();
            firstappContext d = new firstappContext();
            var Customer_Id = Convert.ToInt32((from s in d.Customer where s.CustomerName == CustomerName select s.CustomerId).FirstOrDefault());
            var Product_Id = Convert.ToInt32((from s in d.Product where s.ProductName == ProductName select s.ProductId).FirstOrDefault());
            if(Customer_Id != 0 || Product_Id != 0)
            {
                c.CustomerId = Customer_Id;
                c.ProductId = Product_Id;
                c.OrderStatus = "Ordered";
                string payment = HttpContext.Request.Form["payment"].ToString();
                if(payment == "Online")
                {
                    c.OrderPaymentStatus = "Paid Online";
                    d.Add(c);
                    d.SaveChanges();
                    var OrderId = Convert.ToInt32((from s in d.ProductOrder orderby s.OrderId descending select s.OrderId).FirstOrDefault());
                    g.OrderId = OrderId;
                    var Addres = Convert.ToInt32((from s in d.Address where s.CustomerId == Customer_Id select s.AddressId).FirstOrDefault());
                    g.AddressId = Addres;
                    g.DeliveryStatus = "Dispatched";
                    g.PaymentStatus = "Paid";
                    g.EmployeeId = 1;
                    d.Add(g);
                    d.SaveChanges();
                }
                else
                {
                    c.OrderPaymentStatus = "To be paid during delivery";
                    d.Add(c);
                    d.SaveChanges();
                    var OrderId = Convert.ToInt32((from s in d.ProductOrder orderby s.OrderId descending select s.OrderId).FirstOrDefault());
                    g.OrderId = OrderId;
                    var Addres = Convert.ToInt32((from s in d.Address where s.CustomerId== Customer_Id select s.AddressId).FirstOrDefault());
                    g.AddressId = Addres;
                    g.DeliveryStatus = "Dispatched";
                    g.PaymentStatus = "To be collected at site";
                    g.EmployeeId = 1;
                    d.Add(g);
                    d.SaveChanges();

                }
                var Order_Id = Convert.ToInt32((from s in d.ProductOrder orderby s.OrderId descending select s.OrderId ).FirstOrDefault());
                f.OrderId = Order_Id;
                f.ProductId = Product_Id;
                d.Add(f);
                d.SaveChanges();
                ViewData["Message"] = "Order successfully placed";
               
               Inventory zeq = new Inventory();
                Inventory y = (from s in d.Inventory where s.ProductId == Product_Id select s).FirstOrDefault();
                if (y.Quantity < 2)
                {
                    y.Stock = 0;
                    ViewData["message"] = "Product Not Available";
                    d.SaveChanges();
                }
                else if (y.Quantity >= 2)
                {
                    y.Quantity = y.Quantity - 1;
                    d.SaveChanges();
                }

            }
            else
            {
                ViewData["Message"] = "Invalid customer name or product name";
            }
            return View();
        }
        public IActionResult TrackDelivery()
        {
            return View();
        }
        public IActionResult AddDelivery()
        {
            Delivery a = new Delivery();
            firstappContext b = new firstappContext();
            string CustomerName = HttpContext.Request.Form["cname"].ToString();
            string ProductName = HttpContext.Request.Form["pname"].ToString();
            var CustomerId = Convert.ToInt32((from s in b.Customer where s.CustomerName == CustomerName select s.CustomerId).FirstOrDefault());
            var ProductId = Convert.ToInt32((from s in b.Product where s.ProductName == ProductName select s.ProductId).FirstOrDefault());
            var OrderId = Convert.ToInt32((from s in b.ProductOrder where s.CustomerId == CustomerId && s.ProductId == ProductId select s.OrderId).FirstOrDefault());
            var deli = Convert.ToInt32((from s in b.Delivery where s.OrderId == OrderId select s.DeliveryId).FirstOrDefault());
            if (OrderId != 0 && deli!=0)
            {
                var Delivery_Status = ((from s in b.Delivery where s.OrderId == OrderId select s.DeliveryStatus).FirstOrDefault().ToString());
                var Payment_Status = ((from s in b.Delivery where s.OrderId == OrderId select s.PaymentStatus).FirstOrDefault().ToString());
                ViewData["Delivery"] = Delivery_Status;
                ViewData["Payment"] = Payment_Status;
            }
            else
            {
                ViewData["Delivery"]=ViewData["Payment"] = "Invalid delivery details";
            }
            return View();
        }
        public IActionResult MyCart()
        {
            return View();
        }

        public IActionResult reviews()
        {
            return View();
        }
       public IActionResult AddCart()
        {

            Customer a = new Customer();
            ProductOrder b = new ProductOrder();
            firstappContext c = new firstappContext();
            string CustomerName = HttpContext.Request.Form["cname"].ToString();
            var CustomerId = Convert.ToInt32(((from s in c.Customer where s.CustomerName == CustomerName select s.CustomerId).FirstOrDefault()));
            List<int> ProductIds = ((from s in c.ProductOrder where s.CustomerId == CustomerId select s.ProductId).ToList<int>());
            List<Product> Records = new List<Product>();
            double tp = 0.0;
            foreach(var rec in ProductIds)
            { Product g = new Product();
               g= (Product)(from s in c.Product where s.ProductId == rec select s).FirstOrDefault();
                tp += g.Price;
                Records.Add(g);
                ViewData["TotalPrice"] = tp;
                 }
            return View(Records);
}
        public IActionResult Display()
        { Product pr = new Product();
            Inventory p = new Inventory();
            List<int> counts = new List<int>();
            firstappContext c = new firstappContext();
            List<Product> Products = new List<Product>();
            List<int> CountInventory = new List<int>();
            var k = 0;
            List<int> ProductId = ((from s in c.Product select s.ProductId).ToList<int>());
            List<int> InventoryProductId = ((from s in c.Inventory where s.Quantity >= 1 select s.ProductId).ToList<int>());
           
                   
            
            foreach (var rec in InventoryProductId)
            {
                Product g = new Product();
                g = (Product)(from s in c.Product where s.ProductId==rec select s).FirstOrDefault();
                Products.Add(g);
            }
            return View(Products);
        }
        
        public IActionResult Query()
        {
            return View();
        }
        public IActionResult AddQuery()
        {
            firstappContext b = new firstappContext();
            Queries d = new Queries();
            var ProductName = HttpContext.Request.Form["pname"].ToString();
            var CustomerName = HttpContext.Request.Form["cname"].ToString();
            var ProductId = Convert.ToInt32((from s in b.Product where s.ProductName == ProductName select s.ProductId).FirstOrDefault());
            var CustomerId = Convert.ToInt32((from s in b.Customer where s.CustomerName == CustomerName select s.CustomerId).FirstOrDefault());
            var OrderId = Convert.ToInt32((from s in b.ProductOrder where s.ProductId == ProductId && s.CustomerId == CustomerId select s.OrderId).FirstOrDefault());
            var query = HttpContext.Request.Form["query"].ToString();
            if (OrderId != 0 && CustomerId != 0 && ProductId != 0)
            {
                d.Cquery = query;
                d.EmployeeId = 1;
                d.OrderId = OrderId;
                d.Qstatus = "Registered";
                b.Add(d);
                b.SaveChanges();
                ViewData["Message"] = "Query registered successfully";
            }
            else
            {
                ViewData["Message"] = "Invalid details";
            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
