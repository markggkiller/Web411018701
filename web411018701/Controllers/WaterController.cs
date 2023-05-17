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
            var result = "";
            if (weight.HasValue)
            {
                result = (weight.Value * 30) + "cc";
            }

            // 將數值傳給 view 顯示
            ViewBag.Name = name;
            ViewBag.Result = result;

            return View();
        }
    }
}