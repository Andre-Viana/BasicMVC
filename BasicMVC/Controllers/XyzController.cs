using BasicMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMVC.Controllers
{
    public class XyzController : Controller
    {
        // GET: Xyz
        public JsonResult Abc()
        {
            Student andre = new Student();
            andre.studentId = 1;
            andre.firstName = "André Luiz";
            andre.lastName = "Almeida Viana";

            Student lynda = new Student();
            lynda.studentId = 2;
            lynda.firstName = "Lynda";
            lynda.lastName = "Berry";

            Student john = new Student();
            john.studentId = 3;
            john.firstName = "John";
            john.lastName = "Doe";

            List<Student> students = new List<Student>();
            students.Add(andre);
            students.Add(lynda);
            students.Add(john);

            return Json(students, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}