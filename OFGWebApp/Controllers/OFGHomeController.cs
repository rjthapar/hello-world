using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OFGWebApp.Controllers
{
    public class OFGHomeController : Controller
    {
        // GET: OFGHome
        public ActionResult Index()
        {
            return View();
        }
    }
}