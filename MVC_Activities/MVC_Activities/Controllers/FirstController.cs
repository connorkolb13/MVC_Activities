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
            return View(viewName: "Index", model: "Welcome to my humble MVC Project Webpage.");
        }

        [HttpPost]
        public ActionResult SayHello(string inputString)
        {
            return View(viewName: "Index", model: "Hello " + inputString + ", that's a very nice name you've got there.");
        }

        public ActionResult Square()
        {
            return View(viewName: "Square", model: new double[2]);
        }

        [HttpPost]
        public ActionResult SaySquare(double inputNumber)
        {
            return View(viewName: "Square", model: getValues(inputNumber));
        }

        public double[] getValues(double inputNumber)
        {
            double[] values = new double[2];
            values[0] = inputNumber * inputNumber;
            values[1] = inputNumber * inputNumber * inputNumber;
            return values;
        }
    }
}