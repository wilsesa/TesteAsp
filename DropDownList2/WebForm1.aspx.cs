using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownList2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet DS = new DataSet();
                DS.ReadXml(Server.MapPath("Frutas.xml"));

                ddlFrutas.DataSource = DS;

                ddlFrutas.DataValueField = "FrutaID";
                ddlFrutas.DataTextField = "FrutaNombre";

                ddlFrutas.DataBind();
            }
        }
    }
}