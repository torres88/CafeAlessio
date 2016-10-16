using System.Web.Mvc;

namespace CafeAlessio.Web.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        //public override void RegisterArea(AreaRegistrationContext context)
        //{
        //    context.MapRoute(
        //        "Admin_default",
        //        "Admin/{controller}/{action}/{id}",
        //        new { action = "Index", id = UrlParameter.Optional }
        //    );
        //}
        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "CafeAlessio.Web.Areas.Admin.Controllers" }
            );
        }
    }
}
