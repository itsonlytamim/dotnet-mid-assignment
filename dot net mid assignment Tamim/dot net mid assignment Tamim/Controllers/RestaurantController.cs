using dot_net_mid_assignment_Tamim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dot_net_mid_assignment_Tamim.Controllers
{
    public class RestaurantController : Controller
    {
        public ActionResult OpenCollectRequest()
        {
            using (var db = new NGOContext())
            {
                var collectRequests = db.CollectRequests
                       .Include("Restaurant")
                       .ToList();

                return View(collectRequests);
            }

        }

    }
}