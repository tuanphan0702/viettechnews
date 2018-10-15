using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace viettechnews
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Detail",
               url: "news/{id}/{title}",
               defaults: new { controller = "Home", action = "Detail_News", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            //router infact
            routes.MapRoute(
               name: "Detail_inFact",
               url: "in-fact/{id}/{title}",
               defaults: new { controller = "Home", action = "Detail_inFact", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "Detail_LQ",
               url: "news/{id}/{title}",
               defaults: new { controller = "Home", action = "Detail_New_LQ", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "Archive_giaitri",
               url: "news/giai-tri",
               defaults: new { controller = "Home", action = "Archive_giaitri", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "Archive_congnghe",
               url: "tin-cong-nghe",
               defaults: new { controller = "Home", action = "Archive_congnghe", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "Archive_thegioi",
               url: "tin-the-gioi",
               defaults: new { controller = "Home", action = "Archive_thegioi", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "Archive_thethao",
               url: "news/the-thao",
               defaults: new { controller = "Home", action = "Archive_thethao", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "Archive_gaming",
               url: "news/gaming",
               defaults: new { controller = "Home", action = "Archive_gaming", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "Archive_kientruc",
               url: "tin-kien-truc",
               defaults: new { controller = "Home", action = "Archive_kientruc", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "infact",
               url: "in-fact",
               defaults: new { controller = "Home", action = "inFact", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );


            routes.MapRoute(
               name: "Archive_news",
               url: "tin-tuc",
               defaults: new { controller = "Home", action = "Archive_news", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "Pcs_news",
               url: "tin-cong-nghe/Pcs",
               defaults: new { controller = "Home", action = "Pcs_news", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "Mobile_News",
               url: "tin-cong-nghe/Mobile",
               defaults: new { controller = "Home", action = "Mobile_news", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "Tablet_News",
               url: "tin-cong-nghe/Tablet",
               defaults: new { controller = "Home", action = "Tablet_news", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "Camere_News",
               url: "tin-cong-nghe/Camera",
               defaults: new { controller = "Home", action = "Camera_news", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "Windows_News",
               url: "tin-cong-nghe/Windows",
               defaults: new { controller = "Home", action = "Windows_news", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );


            routes.MapRoute(
               name: "Suckhoe_news",
               url: "news/suc-khoe",
               defaults: new { controller = "Home", action = "Suckhoe_news", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );
            routes.MapRoute(
               name: "Dulich_news",
               url: "news/du-lich",
               defaults: new { controller = "Home", action = "Dulich_news", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );
            routes.MapRoute(
               name: "Picture_news",
               url: "news/phong-thuy",
               defaults: new { controller = "Home", action = "Phongthuy_news", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );
            routes.MapRoute(
               name: "Amthuc_news",
               url: "news/am-thuc",
               defaults: new { controller = "Home", action = "Amthuc_news", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );
            routes.MapRoute(
               name: "Lifestyle_news",
               url: "news/phong-cach",
               defaults: new { controller = "Home", action = "Lifestyle_news", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );
            routes.MapRoute(
               name: "Auto_news",
               url: "tin-auto",
               defaults: new { controller = "Home", action = "Auto_news", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );
            routes.MapRoute(
               name: "Kinhdoanh_news",
               url: "news/kinh-doanh",
               defaults: new { controller = "Home", action = "Kinhdoanh_news", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "Blog",
               url: "news/blog",
               defaults: new { controller = "Home", action = "Blog", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Controllers" }
           );

            routes.MapRoute(
               name: "admin-login",
               url: "Admin/login",
               defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "viettechnews.Areas.Admin.Controllers" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "viettechnews.Controllers" }
            );
        }
    }
}
