using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeetingApp.DAL;

namespace MeetingApp.Controllers
{
    [Authorize(Roles = "E, BE, A, LA")]
    public class SchedulesController : Controller
    {
        // GET: Schedules
        public ActionResult Index()
        {
            return View();
        }
    }
}