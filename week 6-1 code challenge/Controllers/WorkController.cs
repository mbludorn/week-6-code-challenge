using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace week_6_1_code_challenge.Controllers
{
    public class WorkController : Controller
    {
        //
        // GET: /Work/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tab1()
        {
            return PartialView();
        }

        public ActionResult Tab2()
        {
            return PartialView();
        }

        public ActionResult Tab3()
        {
            return PartialView();
        }


    }
}
