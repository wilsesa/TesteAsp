using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Boton06
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Hay tres formas enlas que el boton se despliega usualmente.
                //SingleLine, MultiLine, Password
        //Propiedades mas importantes
        //    ReadOnly -    Solo se lee, no se puede escribir en el.
        //    MaxLeagth -   Cantidad máxima de caracyteres que recibe el texbox
        //    Columns   -   Ancho del control en caracteres
        //    ToolTip   -   Da informacion sobre el control
        protected void Page_Load(object sender, EventArgs e)
        {
            //Inicializamos el read only
            txtReadOnly.Text = "Hola a todos mis amigos";

            //Colocamos el focus en un control
            txtMultiLine.Focus();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            lblSingleLine.Text = txtSingleLine.Text;
        }
    }
}