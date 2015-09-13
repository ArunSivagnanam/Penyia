using Penyia.DataAccess;
using Penyia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Penyia.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

           
            using (ScoolContext context = new ScoolContext())
            {

                //context.Connection.Open();
                var students = context.Students.ToList();

                foreach (Student s in students)
                {
                    Console.Write(s.LastName);
                }

                Console.Write("student added");

                return View(students);
                
            }

            
        }

        public ActionResult About()
        {
            return View();
        }



    }
}
