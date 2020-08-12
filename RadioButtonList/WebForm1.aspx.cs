using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioButtonList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //Verificamos que este algo seleccionado
            if(rblFrutas.SelectedItem != null)
            {
                //Obtenemos los datos
                string texto = rblFrutas.SelectedItem.Text;
                string valor = rblFrutas.SelectedItem.Value;
                int indice = rblFrutas.SelectedIndex;

                //Mostramos
                Response.Write(texto + "," + valor + "," + indice + "<br>");
            }
        }
    }
}