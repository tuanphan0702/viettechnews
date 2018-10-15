using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace viettechnews
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Application.Add("dem",0);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }

        protected void Application_End()
        {
            Application.Remove("dem");
        }
        //vậy là được rồi. CÒn thắc mắc gì nào? dạ cái số người online này vậy là được hả thầy
        // h em gọi nó ra thế nào ạ :D
        //ok. em muốn in ra chỗ nào thì mở ra mình chỉ
        void Session_Start(object sender, EventArgs e)
        {
            int so = int.Parse(Application.Get("dem").ToString());
            so++;
            Application.Set("dem", so);
        }

        void Session_End(object sender, EventArgs e)
        {
            int so = int.Parse(Application.Get("dem").ToString());
            so--;
            Application.Set("dem", so);
        }
    }
}
