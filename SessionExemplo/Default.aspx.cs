using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionExemplo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Salvar()
        {
            try
            {
                if (txtNome.Text != string.Empty)
                {
                    Session["Salvar"] = this.txtNome.Text;
                    this.lblNome.Text = "Arquivo salvo en Session!";
                }
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}