using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VariablesSesion04
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private int conteo = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtConteo.Text = "0";
            }
            if (Session["click"] != null)
            {
                txtConteo.Text = ((int)Session["click"]).ToString();
            }
        }

        protected void btnIncrementa_Click(object sender, EventArgs e)
        {
            //Si ya se a usado la avariable click
            if (Session["Click"] != null)
            {
                //Leemos el valor, hacemos typecast, lo incrementamos y lo colocamos
                //    en la  variable para poder trabajar con este dato

                conteo = (int)Session["Click"] + 1;
            }
            //Actualizamos el texBox
            txtConteo.Text = conteo.ToString();

            //Asignamos el valor en la variable click
            Session["Click"] = conteo;
        }
    }
}