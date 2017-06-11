using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MTweb_beta.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult  Index()
        {
            return View();
        }
        public string welcome(string name="  poi~" )
        {
            return "welcome to mvc" + HttpUtility.HtmlEncode(name);
        }
        public ActionResult helloword(string a = "默认",int b = 1)
        {
            ViewBag.Message = "Hello" + a;
            ViewBag.NumTimes = b;

            return View();
        }
    }
}