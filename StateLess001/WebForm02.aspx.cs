using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateLess001
{
    public partial class WebForm02 : System.Web.UI.Page
    {
        //ViewState nos permite preservar los datos entre requests
        //Tenemos que colocar el nombre de la variable para el ViewState
        //Cuando lo leamos es importante hace el typecast cotrrespondiente

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
            if (ViewState["Click"] != null)
            {
                //Leemos el valor, hacemos typecast, lo incrementamos y lo colocamos
                //    en la  variable para poder trabajar con este dato

                conteo = (int)ViewState["Click"] + 1;
            }
            //Actualizamos el texBox
            txtConteo.Text = conteo.ToString();

            //Asignamos el valor al viewState en la variable click
            ViewState["Click"] = conteo;
        }
    }
}