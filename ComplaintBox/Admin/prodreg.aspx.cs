using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.Admin
{
    public partial class prodreg : System.Web.UI.Page
    {
        BAL.ProBAL objprobal = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objprobal.Product_Name = TextBox1.Text;
            objprobal.Price = TextBox2.Text;
            int i = objprobal.ProductReg();
            if (i == 1)
            {
                Response.Write("<script>alert('Product Register Success ');</script>");
            }

        }
    }
}