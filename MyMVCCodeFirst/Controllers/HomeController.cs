using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MyMVCCodeFirst.Models;

namespace MyMVCCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            using (var context = new SchoolContext())
            {
                var school = new School() { Name = "Imelda"};
                var school2 = new School() { Name = "Imelda2" };


                var student = new Student() { Name = "student", Age = 18, School = school };
            var student0 = new Student() { Name = "student0", Age = 18, School = school };
            var student5= new Student() { Name = "student5", Age = 18, School = school };
            var student2 = new Student() { Name = "student2", Age = 18, School = school };
            var teacher = new Teacher() { Name = "Kenan" };
            var teacher1 = new Teacher() { Name = "Wouter"};
            school.Students.Add(student);
            school.Students.Add(student2);
                school.Teachers.Add(teacher);
                school.Teachers.Add(teacher1);
                school2.Teachers.Add(teacher);
          
                context.Schools.Add(school);
                context.Schools.Add(school2);
                context.SaveChanges();
               
   
                 return View();
            }

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}