using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View(viewName: "Index", model: "Enter your full name.");
        }

        [HttpPost]
        public ActionResult getInitials(string name)
        {
            string[] words = name.Split(null);
            String initials = "";
            foreach (String word in words) {
                initials += word[0];
            }
            initials.ToUpper();
            return View(viewName: "Index", model: "Your initials:" + initials);
        }

    }
}
