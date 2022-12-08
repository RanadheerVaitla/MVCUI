using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUIDesigning.Models;

namespace MVCUIDesigning.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Index1(Student s)
        {
            return View("DisplayEmp",s);
        }
        [HttpGet]
        public ViewResult AddStudentST()
        {
            return View();
        }
        public ViewResult AddStudentST(Student z)
        {
            return View("DisplayEmp1",z);
        }
    }
}