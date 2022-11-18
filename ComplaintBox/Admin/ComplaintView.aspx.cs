using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.Admin
{
    public partial class ComplaintView : System.Web.UI.Page
    {
        BAL.ProBAL objprobal = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView2.DataSource = objprobal.viewComplaintAll();
            GridView2.DataBind();
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            objprobal.ToDate = TextBox2.Text;
            objprobal.FromDate =TextBox1.Text;
            GridView1.DataSource = objprobal.viewComplaint();
            GridView1.DataBind();  
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objprobal.C_Id = id;
            int i = objprobal.StatusProgres();
            GridView1.EditIndex = -1;
            
            GridView2.DataSource = objprobal.viewComplaintAll();
            GridView2.DataBind();

            GridView1.DataSource = objprobal.viewComplaint();
            GridView1.DataBind();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {

            objprobal.ToDate = TextBox2.Text;
            objprobal.FromDate = TextBox1.Text;
            GridView3.DataSource = objprobal.ComplaintClosed();
            GridView3.DataBind();
        }
        protected void GridView3_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView3.DataKeys[e.RowIndex].Value.ToString());
            objprobal.C_Id = id;
            int i = objprobal.StatusClosed();
            GridView1.EditIndex = -1;

            GridView2.DataSource = objprobal.viewComplaintAll();
            GridView2.DataBind();

            GridView3.DataSource = objprobal.viewComplaint();
            GridView3.DataBind();
        }
    }
}