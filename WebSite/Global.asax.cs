using Common;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebSite.Biz;

namespace WebSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            startPing();
        }

        private void startPing()
        {
            
            new Thread(new ThreadStart(() =>
            {
                LogHelper log = new LogHelper();
                int times = 0;
                while (true)
                {
                    log.LogInfo(++times + "次");
                    ITargetBll tb = new ExcelTargetBll();
                    PingHelper.ipTable = tb.GetTargetIPList();
                    PingHelper.ping();
                    for (int i = 0; i < 2; i++)
                    {
                        Thread.Sleep(1000 * 60 * 1);
                        PingHelper.Reping();
                    }
                    Thread.Sleep(1000 * 60 * 3);
                }
            })).Start() ;
            
        }
    }
}
