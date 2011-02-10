using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineUserGroup.Web.Models;

namespace OnlineUserGroup.Web.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new Appointment {
                Title = "ASP.NET MVC Gruppe: Wir starten mit der WebSite",
                Date = new DateTime(2011, 2, 10, 20, 0, 0)
            };

            if (Request.IsAjaxRequest())
                return Json(model, JsonRequestBehavior.AllowGet);
            return View(model);
        }
    }
}