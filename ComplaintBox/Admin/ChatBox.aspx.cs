using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.Admin
{
    public partial class ChatBox : System.Web.UI.Page
    {
        BAL.ProBAL objprobal = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView3.DataSource = objprobal.ViewQueries();
            GridView3.DataBind();
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        
    }
}