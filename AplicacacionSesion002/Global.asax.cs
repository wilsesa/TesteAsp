using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace AplicacacionSesion002
{
    public class Global : HttpApplication
    {
        //Este handler se ejecuta cuando se crea una instancia de la aplicacion
        void Application_Start(object sender, EventArgs e)
        {
            // Código que é executado na inicialização do aplicativo
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Creamos variables de estado para la aplicacon.
            //Puede ser leida por todas las sesiones
            Application["Aplicaciones"] = 0;
            Application["SesionesUsuario"] = 0;

            //Incrementamos
            Application["Aplicaciones"] = (int)Application["Aplicaciones"] + 1;
        }

        //Este handler se ejecuta cuando se crea una sesion
        void Session_Star(object sender, EventArgs e)
        {
            Application["SesionesUsuario"] = (int)Application["SesionesUsuario"] + 1;
        }


        void Session_End(object sender, EventArgs e)
        {
            Application["SesionesUsuario"] = (int)Application["SesionesUsuario"] - 1;
        }
    }
}