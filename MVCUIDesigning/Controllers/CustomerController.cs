using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUIDesigning.Models;

namespace MVCUIDesigning.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            Customer C1 = new Customer { Custid = 101, Name = "Anil", Account = "Savings" };
            Customer C2 = new Customer { Custid = 102, Name = "Sunil", Account = "Savings" };
            Customer C3 = new Customer { Custid = 103, Name = "Ajay", Account = "Savings" };
            List<Customer> C = new List<Customer> { C1, C2, C3 };
            return View(C);            
            
        }
        
    }
}