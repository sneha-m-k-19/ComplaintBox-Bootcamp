using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.Admin
{
    public partial class UserVerification : System.Web.UI.Page
    {
        BAL.ProBAL objprobal = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = objprobal.viewUser();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objprobal.login_id = id;
            int i = objprobal.approveUser();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objprobal.viewUser();
            GridView1.DataBind();
        }
    }
}