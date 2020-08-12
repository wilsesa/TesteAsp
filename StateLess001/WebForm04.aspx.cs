using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateLess001
{
    public partial class WebForm04 : System.Web.UI.Page
    {
        //Mismo codigo y mismo nombre de variables de estado que webfom2
        private int conteo = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtConteo.Text = "0";
            }
        }

        protected void btnIncrementa_Click(object sender, EventArgs e)
        {
            //Si ya se a usado el viewstate con la variable click
            if(ViewState["click"] != null)
            {
                //Leemos el valor hacemos typecast, lo incrementamos y lo colocamos
                //    en la variable para poder trabajar con este dato en nuestro codigo
                conteo = (int)ViewState["click"] + 1;
            }
            //Actualizamos el texbox
            txtConteo.Text = conteo.ToString();

            //Asignamos el valor al ViewState en la variable click
            ViewState["click"] = conteo;
        }
    }
}