using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownList11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem fresa = new ListItem("Fresa", "6");
                ListItem naranja = new ListItem("Naranja", "7");

                ddlFrutas.Items.Add(fresa);
                ddlFrutas.Items.Add(naranja);
            }

        }

        protected void btnPrueba_Click(object sender, EventArgs e)
        {
            lblIndice.Text = ddlFrutas.SelectedIndex.ToString();
            lblValor.Text = ddlFrutas.SelectedValue.ToString();
            //lblSelecionado.Text = ddlFrutas.SelectedItem.ToString();
            lblSelecionado.Text = ddlFrutas.Items[ddlFrutas.SelectedIndex].ToString();
        } 
    }
}