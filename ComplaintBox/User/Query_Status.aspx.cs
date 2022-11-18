using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.User
{
    public partial class Query_Status : System.Web.UI.Page
    {
        BAL.ProBAL objprobal = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            objprobal.login_id = Convert.ToInt16(Session["id"]);
            GridView3.DataSource = objprobal.viewMyQuery();
            GridView3.DataBind();

        }
    }
}