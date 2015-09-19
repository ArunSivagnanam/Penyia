using Penyia.DataAccess;
using Penyia.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            using (PenyiaContext context = new PenyiaContext())
            {

                /*
                //context.Connection.Open();
                var users = context.Users.ToList();

                foreach (User u in users)
                {
                    Console.Write(u.LastName);
                }

                Console.Write("user added");
                 */
                return View();
               
            }

            
        }

        public ActionResult About()
        {

            Test t = new Test(5)
            {
                cat = "cat",
                dog = "dog"

            };

            t.optional(5);


            // casting

            SpecialTest sp = new SpecialTest();


            Test y = sp as Test;

            if (y != null)
            {
                Debug.WriteLine("not null");
            }

            if (sp is Test)
            {
                Debug.WriteLine("sp is a Test");
            }




            return View();
        }



    }
}
