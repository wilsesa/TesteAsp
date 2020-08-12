using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesEventos05
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Los controles ASP tienen sus propios controles.
        //POSTBACK - Estos eventos envian al webfoms al servidor para ser procesada -> click
        //CACHED - Estos eventos se guardan y de procesan cuando sucede un postback
            //se puede convertir en PostBack por medio de la propiedad AutoPostBack.
        //VALIDACION - Son usados con los controles de validacion
            //Ocurren el el cliente antes que el webforms se envie al servidor
        //protected void Page_Load(object sender, EventArgs e)
        //{

        //}

        protected void btnPostBack_Click(object sender, EventArgs e)
        {
            lblMensajePB.Text = "Ya ocurrio el evento PostBack...";
            Response.Write("Ya ocurrio el evento PostBack...<br/>");
        }

        //Este evento sucede cuando hay un cambio en el texto del texbox.
        //Despues de probar?...mofificar para AutoPostBack.
        //Colocar Enabled en true para ver el ejemplo

        protected void txtChanged_TextChanged(object sender, EventArgs e)
        {
            lblMensajeCached.Text = "Ya ocurrio el evento cached";
            Response.Write("Ya ocurrio el evento cached...<br/>");
        }

        //Colocar esto despues de ver el ejemplo de validacion

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("1) PreInit <br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("2) Init <br/>");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("3) InitComplete <br/>");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("4) PreLoad <br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("5) Load <br/>");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("6) LoadComplete <br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("7) PreRender <br/>");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("8) PreRenderComplete <br/>");
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //No tiene sentido el usu de response en este evento
            //Response.Write("9) UnLoad <br/>");
        }
    }
}