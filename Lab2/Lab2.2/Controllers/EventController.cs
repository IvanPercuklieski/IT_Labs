using Lab2._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2._2.Controllers
{
    public class EventController : Controller
    {
        private static List<Event> eventList = new List<Event>()
        {
            new Event(){ id=1, name="Zhurka", location="Centar"}
        };
        
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Table()
        {
            return View(eventList);
        }

        public ActionResult AddEvent()
        {
            return View();
        }


        [HttpPost]
        public ActionResult InsertEvent(Event newEvent)
        {
            
            if (ModelState.IsValid == false)
            {
                return View("AddEvent", newEvent);
            }

            newEvent.id = eventList.Count+1;
            eventList.Add(newEvent);
            return RedirectToAction("ViewEvent", "Event");
        }

        public ActionResult ViewEvent()
        {
            return View(eventList.Last());
        }

        public ActionResult EditEvent(int id)
        {
            var item = eventList[id-1];
            item.id = id;
            return View(item);
        }

        [HttpPost]
        public ActionResult EditEvent(Event item)
        {
            if (ModelState.IsValid == false)
            {
                return View("EditMovie", item);
            }
            var changed = eventList.ElementAt(item.id-1);
            changed.name = item.name;
            changed.location = item.location;

            return View("Table", eventList);
        }

  
        public ActionResult DeleteEvent(int id)
        {
            eventList.Remove(eventList.FirstOrDefault(item => item.id == id));
            return View("Table", eventList);
        }

    }
}