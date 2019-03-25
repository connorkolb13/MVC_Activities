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
            return View(viewName: "Square", model: new double[3]);
        }

        [HttpPost]
        public ActionResult SaySquare(double inputNumber)
        {
            return View(viewName: "Square", model: getValues(inputNumber));
        }

        public double[] getValues(double inputNumber)
        {
            double[] values = new double[3];
            values[0] = inputNumber * inputNumber;
            values[1] = inputNumber * inputNumber * inputNumber;
            values[2] = Math.Sqrt(inputNumber);
            return values;
        }

        public ActionResult MagicNum()
        {
            return View(viewName: "MagicNum", model: 0);
        }

        [HttpPost]
        public ActionResult getMagicNum(int lowerBound, int upperBound)
        {
            return View(viewName: "MagicNum", model: magicCalc(lowerBound, upperBound));
        }

        public int magicCalc(int low, int high)
        {
            if(low > high) {
                return -999;
            }
            else {
                Random random = new Random();
                return random.Next(low - 1, high + 1);
            }
        }
    }
}