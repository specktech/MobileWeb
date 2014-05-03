using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SPAFull.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        /// <summary>
        /// Sample controller without 
        /// </summary>
        /// <returns></returns>
        public ActionResult Sample()
        {
            return View();
        }
    }
}
