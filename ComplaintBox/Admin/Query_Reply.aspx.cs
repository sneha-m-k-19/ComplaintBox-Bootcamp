using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.Admin
{
    public partial class Query_Reply : System.Web.UI.Page
    {
        BAL.ProBAL objprobal = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int qid = Convert.ToInt32(Request.QueryString["Query_Id"]);
                Session["queryid"] = qid;
                objprobal.Q_Id = qid;
                DataTable dt = objprobal.ViewSpecificQuery();
                if (dt != null)
                {
                    PRoductTextBox1.Text = dt.Rows[0]["Product_Name"].ToString();
                    QuestionTextBox.Text = dt.Rows[0]["Query"].ToString();

                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objprobal.Reply = ReplyTextBox.Text;
            int queryid = Convert.ToInt32(Session["queryid"]);
            objprobal.Q_Id = queryid;
            int i = objprobal.GiveReply();
            if (i == 1)
            {
                Response.Write("<script>alert('Replyed Successfully ');</script>");
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Replyed Successfully" + "');", true);
                Response.Redirect("../Admin/ChatBox.aspx");

            }
        }
    }
}