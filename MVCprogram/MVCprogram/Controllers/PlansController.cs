using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCprogram.Controllers
{
    public class PlansController : Controller
    {
        // GET: Plans
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PlansList()
        {
            return View("PlansList");
        }
    }
}