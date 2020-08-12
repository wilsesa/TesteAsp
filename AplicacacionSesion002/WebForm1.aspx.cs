using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacacionSesion002
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //La sesion de usuario es una instancia de un browser
        //<sessionState mode = "InProc" cookieless="true"> </sessionState>
        //Y nos manda visiblemente el sessionID 

        //Este handler se ejecuta cuando se carga la pagina 
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Cantidad de aplicaciones instanciadas " + Application["Aplicaciones"] + "<br/>");
            Response.Write("Cantidad de sesiones de usuario " + Application["SesionesUsuario"]);
        }
    }
}