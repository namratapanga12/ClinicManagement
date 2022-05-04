using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ClinicManagement
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //ATTRIBUTE ROUTE - FOR BIG APPLICATIONS 
            //action based routing
           // [Route("ProductType/Product/{mindid}/{maxid}")]



            //CUSTOM ROUTE 
            //routes.MapRoute(
               // name: "Get Particular Doctor",
              //  url: "DoctorType/Doctor /{ minid}/{ maxid}",
              //  defaults:new { controller = "DoctorType", action = "Doctor" }

              //  );
            routes.MapRoute(
                name: "Default",
                //DoctorType/Doctor/1/3
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
