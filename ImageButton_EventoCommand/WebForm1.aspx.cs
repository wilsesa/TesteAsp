using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImageButton_EventoCommand
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("Boton de imagen...!");
        }

        //Este hanler sera usado or diferentes botones
        protected void operaciones(object sender, CommandEventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = 0;

            if (e.CommandName == "Suma")
                r = a + b;
            if (e.CommandName == "Resta")
                r = a - b;
            if (e.CommandName == "Multi")
                r = a * b;
            if (e.CommandName == "Div")
                r = a / b;

            lblResultado.Text = r.ToString();   
        }

        protected void mensaje(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "esp")
            {
                Response.Write("En espanol es: " + e.CommandArgument);
            }
            if(e.CommandName == "ing")
            {
                Response.Write("En ingles es: " + e.CommandArgument);
            }
        }
    }
}