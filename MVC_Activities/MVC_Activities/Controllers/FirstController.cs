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

        public ActionResult MagicNumber()
        {
            return View(viewName: "MagicNumber", model: 0);
        }

        [HttpPost]
        public ActionResult FindNum(int inputNumberLow, int inputNumberHigh)
        {
            if (inputNumberHigh-inputNumberLow<=1)
            {
                return View(viewName: "MagicNumber", model: -999);
            }
            else
            {
                Random gen = new Random();
                
                return View(viewName: "MagicNumber", model: (gen.Next(inputNumberLow+1, inputNumberHigh)));
            }
        }
        
        public ActionResult Dates()
        {
            return View(viewName: "Dates", model: (DateTime.Now));
        }


        [HttpPost]
        public ActionResult DateMagic(DateTime inputBirthday)
        {
            return View(viewName: "Dates", model: inputBirthday);
        }



    }
}