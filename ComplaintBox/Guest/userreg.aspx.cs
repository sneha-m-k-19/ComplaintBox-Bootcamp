using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintBox.User
{
    public partial class userreg : System.Web.UI.Page
    {
        BAL.ProBAL objprobal = new BAL.ProBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objprobal.Name = TextBox1.Text;
            objprobal.Email = TextBox2.Text;
            objprobal.Phone_Number = TextBox3.Text;
            objprobal.Password = TextBox4.Text;
            int i = objprobal.InsertStudent();
            int j = objprobal.LoginInsert();
            if(i == 1)
            {
                Response.Write("<script>alert('Register Success ');</script>");
            }

        }
    }
}