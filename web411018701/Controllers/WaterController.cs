using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web411018701.Controllers
{
    public class WaterController : Controller
    {
        // GET: Water
        public ActionResult Index(String name, float? weight)
        {
            return View();
        }
    }
}