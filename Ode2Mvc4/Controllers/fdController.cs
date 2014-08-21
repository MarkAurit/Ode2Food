using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ode2Mvc4.Controllers
{
    public class fdController : Controller
    {
        //
        // GET: /fd/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string name = "German")
        {
            //var controller = RouteData.Values["controller"];
            //var action = RouteData.Values["action"];
            //var id = RouteData.Values["id"];
            //var message = String.Format("{0}::{1} {2}", controller, action, id);
            var message = Server.HtmlEncode(name);

            return Content(message);
        }

    }
}
