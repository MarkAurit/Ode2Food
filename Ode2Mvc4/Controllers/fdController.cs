using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ode2Mvc4.Filters;

namespace Ode2Mvc4.Controllers
{
    [Log]
    public class fdController : Controller
    {
        //
        // GET: /fd/

        public ActionResult Index()
        {
            return View();
        }

        //5. specify http verb
        //[HttpGet]
        // 6. use authotize
        //[Authorize
        public ActionResult Search(string name)
        {
            //var controller = RouteData.Values["controller"];
            //var action = RouteData.Values["action"];
            //var id = RouteData.Values["id"];
            //var message = String.Format("{0}::{1} {2}", controller, action, id);
            
            var message = Server.HtmlEncode(name);
            
            // 1. display text
            return Content(message);
            // 2. return to action on controller
            //return RedirectToAction("Index", "Home", new {name = name});
            // 3. return to routing table
            //return RedirectToRoute("Default", new {controller = "Home", action = "About"});
            // 4. return json
            //return Json(new {Message = message, time = DateTime.Now.ToShortDateString()}, JsonRequestBehavior.AllowGet);
        }

    }
}
