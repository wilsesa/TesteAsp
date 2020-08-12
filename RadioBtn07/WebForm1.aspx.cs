using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioBtn07
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //PROPIEDADES:
        //    Checked, Text, TextAlign, AutoPastBack, GroupName
        //EVENTOS:
        //    CheckedChanged
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProcesa_Click(object sender, EventArgs e)
        {
            if (rbtnPizza.Checked == true)
                Response.Write("Te recomiendo a hawaiana    <br/>");
            if (rbtnFrutas.Checked == true)
                Response.Write("Te recomiendo la manzana    <br/>");
            if (rbtnVerduras.Checked == true)
                Response.Write("Te recomiendo espinacas <br/>");
        }

        protected void btnConbustible_Click(object sender, EventArgs e)
        {
            if (rbtnGasolina.Checked == true)
                Response.Write("Tu auto utiliza gasolina    <br/>");
            if (rbtnDiesel.Checked == true)
                Response.Write("Tu camion utiliza diesel    <br/>");
            if (rbtnEtanol.Checked == true)
                Response.Write("Tu camioneta utiliza etanol <br/>");
        }

        protected void rbtnGasolina_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("La gasolina es contaminante <br/>");
        }

        protected void rbtnDiesel_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("El diesel es super contaminante e tóxico    <br/>");
        }
    }
}