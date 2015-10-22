using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Web.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DontPanic.Controllers
{
    public class MKTestController : Controller
    {
        // GET: MKTest
        public ActionResult Index()
        {
            using (StreamReader sr = new StreamReader(Server.MapPath("~/mockEventsResponse.json")))
            {
                //get json
                string content = sr.ReadToEnd();

                //parse json to dynamic object
                dynamic jsonResponse = JObject.Parse(content);

                //enumerate events
                dynamic values = jsonResponse.value;
                foreach (dynamic value in values)
                {
                    var f = value.Subject;
                }

            }

            return View();
        }
    }
}