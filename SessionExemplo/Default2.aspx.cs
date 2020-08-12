using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionExemplo
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Recuperar()
        {
            try
            {
                lblNome.Text = "O valor de sua Session é...: " + Session["Salvar"].ToString();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        protected void btnRecuperarDados_Click(object sender, EventArgs e)
        {
            Recuperar();
        }
    }
}