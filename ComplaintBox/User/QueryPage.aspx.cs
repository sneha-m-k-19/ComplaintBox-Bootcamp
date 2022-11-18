using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.User
{
    public partial class QueryPage : System.Web.UI.Page
    {
        BAL.ProBAL objprobal = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = objprobal.GetProduct();
                DropDownList1.DataTextField = "Product_Name";
                DropDownList1.DataValueField = "Product_Id";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objprobal.ProductId = int.Parse(DropDownList1.SelectedItem.Value);
            objprobal.ProductQuery = Request.Form["TextArea1"];
            objprobal.login_id = Convert.ToInt16(Session["id"]);
            objprobal.Name = Convert.ToString(Session["uname"]);
            int i = objprobal.InsertQuery();
            if (i == 1)
            {
                Response.Write("<script>alert('Register Success ');</script>");
            }
        }
    }
}