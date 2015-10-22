using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Web.Hosting;

namespace DontPanic.Controllers
{
    public class MKTestController : Controller
    {
        // GET: MKTest
        public ActionResult Index()
        {
            using (StreamReader sr = new StreamReader(Server.MapPath("~/mockEventsResponse.json")))
            {
                string content = sr.ReadToEnd();
            }

            return View();
        }
    }
}