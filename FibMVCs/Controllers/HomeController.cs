using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FibMVC.Biz;
using System.IO;

namespace FibMVCs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getViews()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public String getFib(String i)
        {
            JObject j = JObject.Parse(i);
            int beginning = int.Parse(j["b"].ToString());
            int end = int.Parse(j["e"].ToString());
            String result = "5";
            //   HttpResponse res = new HttpResponse(new TextWriter);
            return result;

        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}