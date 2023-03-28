using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dot_net_mid_assignment_Tamim.Models;

namespace dot_net_mid_assignment_Tamim.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            {
                using (var db = new NGOContext())
                {
                    var collectRequests = db.CollectRequests
                           .Include("Restaurant")
                           .Include("Employee")
                           .ToList();

                    return View(collectRequests);
                }

            }
        }
    }
}
