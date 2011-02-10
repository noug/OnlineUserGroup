using System;
using System.Globalization;
using System.Web.Mvc;

namespace OnlineUserGroup.Web.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            SetThreadCulture();
        }

        private void SetThreadCulture()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture=new CultureInfo(GetCultureFromRoute());
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(GetCultureFromRoute());
        }

        private string GetCultureFromRoute()
        {
            string culture = ControllerContext.RouteData.Values["culture"].ToString().ToLower();
            if (culture == "de-de")
                return culture;
            throw new InvalidOperationException("unbekannte culture-angabe");
        }
    }
}