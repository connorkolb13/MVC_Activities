using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_Activities.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View(viewName: "Index", model: "Cleaned Up Messege");
        }

        [HttpPost]
        public ActionResult SayHello(string inputString)
        {
            return View(viewName: "Index", model: "Hello " + inputString + " your dumb");
        }

        public ActionResult Square()
        {
            return View(viewName: "Square", model: 0.0);
        }


        [HttpPost]
        public ActionResult SaySquare(double inputNumber)
        {
            return View(viewName: "Square", model: (Math.Sqrt(inputNumber)));
        }


    }
}