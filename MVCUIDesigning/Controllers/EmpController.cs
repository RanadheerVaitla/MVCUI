using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUIDesigning.Models;
namespace MVCUIDesigning.Controllers
{
    public class EmpController : Controller
    {       
        [HttpGet]
        public ActionResult AddEmp()
        {
            return View();
        }
        
        //public ViewResult AddEmp(int? id,string name,string job,double? salary)
        //{
        //    ViewData["Id"] = id;
        //    ViewData["Name"] = name;
        //    ViewData["Job"] = job;
        //    ViewData["Salary"] = salary;
        //    return View("DisplayEmp");
        //}
        //[HttpPost]
        //public ViewResult AddEmp(FormCollection fc)
        //{
        //    ViewData["Id"] = fc["Id"];
        //    ViewData["Name"] = fc["Name"];
        //    ViewData["Job"] = fc["Job"];
        //    ViewData["Salary"] = fc["Salary"];
        //    return View("DisplayEmp2");
        //}
        [HttpPost]
       public ViewResult AddEmp(Emp emp)
        {
            return View("DisplayEmp3", emp);
        }
    }
}