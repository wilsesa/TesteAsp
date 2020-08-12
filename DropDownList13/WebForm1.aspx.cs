using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace DropDownList13
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string  cCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True";
            using (var con = new SqlConnection(cCon))
            {
                con.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Comestibles", con))
                {
                    using ( var reader = cmd.ExecuteReader())
                    {
                        ddlFrutas1.DataSource = reader;
                        ddlFrutas1.DataValueField = "id";
                        ddlFrutas1.DataTextField = "nombre";
                        ddlFrutas1.DataBind();
                    }
                }
            }
        }
    }
}