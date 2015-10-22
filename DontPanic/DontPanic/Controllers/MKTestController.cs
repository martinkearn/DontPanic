using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Web.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DontPanic.Models;

namespace DontPanic.Controllers
{
    public class MKTestController : Controller
    {
        // GET: MKTest
        public ActionResult Index()
        {
            List<Event> events = new List<Event>();
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
                    Event e = new Event();
                    e.Subject = value.Subject;
                    e.Start = value.Start;
                    e.End = value.End;
                    e.ShowAs = value.ShowAs;
                    //e.Categories = value.Categories;
                    events.Add(e);
                }
               

            }

            var vm = new EventsViewModel() { Events = events };

            return View(vm);
        }
    }
}