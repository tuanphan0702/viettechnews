using System.Web.Mvc;

namespace viettechnews.Areas.Admin
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

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            // Khai báo index tin tức
            context.MapRoute(
                "tintuc", // Duy nhất
                "quan-tri/tin-tuc",
                new { action = "Index", controller="Tintuc", id = UrlParameter.Optional }
            );

            // Khai báo index tin tức
            context.MapRoute(
                "danhmuc", // Duy nhất
                "quan-tri/danh-muc",
                new { action = "Index", controller = "Danhmuc", id = UrlParameter.Optional }
            );

            // Khai báo index tin tức
            context.MapRoute(
                "account", // Duy nhất
                "quan-tri/account",
                new { action = "Index", controller = "Account", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}