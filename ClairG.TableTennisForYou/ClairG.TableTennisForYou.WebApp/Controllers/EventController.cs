using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClairG.TableTennisForYou.WebApp.Controllers
{
    public class EventController : Controller
    {
        //Event/Monthly Event
        public ActionResult MEvent()
        {
            return View();
        }
        //Event/ITTF World Tour
        public ActionResult WTour()
        {
            return View();
        }
        //Event/World Champions
        public ActionResult WChampions()
        {
            return View();
        }
        //Event/Tokyo 2020
        public ActionResult Tokyo()
        {
            return View();
        }
    }
}