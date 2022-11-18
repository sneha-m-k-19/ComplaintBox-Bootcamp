using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ComplaintBox.DAL
{

    public class ProDAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public ProDAL()
        {
            //calling connection string connection string should be set in web.config file
            string conn = ConfigurationManager.ConnectionStrings["complaint"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection GetCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public int UserInsert(BAL.ProBAL obj)
        {
            string qry = "insert into Tbl_User values('" + obj.Name + "','" + obj.Email + "','" + obj.Phone_Number + "')";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public int InsertLogin(BAL.ProBAL obj)
        {
            string qry1 = "insert into Login values('" + obj.Name + "','User','" + obj.Password + "','waiting')";
            SqlCommand cmd = new SqlCommand(qry1, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public int RegProd(BAL.ProBAL obj)
        {
            string qry2 = "insert into Product values('" + obj.Product_Name + "'," + obj.Price + ")";
            SqlCommand cmd = new SqlCommand(qry2, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable UserView()
        {
            string s = "select *from Login where status='waiting'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public int userApprove(BAL.ProBAL obj)
        {
            string s = "Update Login set status='Confirm' where login_id =" + obj.login_id ;
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable PageLogin(BAL.ProBAL obj)
        {
            string qry3 = "SELECT * FROM Login WHERE Username ='"+obj.Name+"' AND Password='"+obj.Password+"'";          
            SqlCommand cmd = new SqlCommand(qry3, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ProdView()
        {
            string s = "select *from Product";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public DataSet ProdIdView()
        {
            string s = "select *from Product";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public int Complaint(BAL.ProBAL obj)
        {
            string qry2 = "insert into Complaint(User_Id,UserName,Product_Id,Complaint,Status,C_Date) values('" + obj.login_id +"','" +obj.Name+"','" + obj.ProductId + "','" + obj.Complaint + "','Notyet',GETDATE() )";
            SqlCommand cmd = new SqlCommand(qry2, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public int QueryInsert(BAL.ProBAL obj)
        {
            string qry2 = "insert into Query(Product_Id,User_Id,UserName,Query,Reply) values('" + obj.ProductId + "','" + obj.login_id + "','" + obj.Name + "','" + obj.ProductQuery + "','Reply Waiting')";
            SqlCommand cmd = new SqlCommand(qry2, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable GetProDetails(BAL.ProBAL obj)
        {
            string qry2 = "select * from Product";
            SqlCommand cmd = new SqlCommand(qry2, GetCon());
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        public DataTable ComplaintView(BAL.ProBAL obj)
        {
            // string qry2 = "select * from complaint where status='Notyet'";
            string qry2 = "select * from complaint where Status='Notyet' AND C_Date >= '" + obj.FromDate + "' AND C_Date<='" + obj.ToDate+"'";
            SqlCommand cmd = new SqlCommand(qry2, GetCon());
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        public DataTable ComplaintViewAll(BAL.ProBAL obj)
        {
           
             string qry2 = "select * from complaint";
            //string qry2 = "select * from complaint where Status='Notyet' AND C_Date >= '" + obj.FromDate + "' AND C_Date<='" + obj.ToDate + "'";
            SqlCommand cmd = new SqlCommand(qry2, GetCon());
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        public int ProgresStatus(BAL.ProBAL obj)
        {
            string s = "Update complaint set Status='inProgress' where C_id =" + obj.C_Id;
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public int ClosedStatus(BAL.ProBAL obj)
        {
            string s = "Update complaint set Status='Closed' where C_id =" + obj.C_Id;
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable ClosedComplaint(BAL.ProBAL obj)
        {
            // string qry2 = "select * from complaint where status='Notyet'";
            string qry2 = "select * from complaint where Status='inProgress' AND C_Date >= '" + obj.FromDate + "' AND C_Date<='" + obj.ToDate + "'";
            SqlCommand cmd = new SqlCommand(qry2, GetCon());
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        public DataTable MyselfView(BAL.ProBAL obj)
        {
            
            string qry2 = "select * from complaint where User_Id="+obj.login_id;
            SqlCommand cmd = new SqlCommand(qry2, GetCon());
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        public DataTable QueriesView(BAL.ProBAL obj)
        {

            string qry2 = "select * from Query where Reply= 'Reply Waiting'";
            SqlCommand cmd = new SqlCommand(qry2, GetCon());
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        public DataTable ReplyQuery(BAL.ProBAL obj)
        {
            string s = "Update Query set Reply='"+obj.Reply+"' where Query_id =" + obj.Q_Id;
            SqlCommand cmd = new SqlCommand(s, GetCon());
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;

        }
        public DataTable ViewSpecificQueryDetails(BAL.ProBAL querybal)
        {
            string qry = "SELECT l.Username,p.*,q.* FROM Query q INNER JOIN Login l ON l.login_id= q.User_Id INNER JOIN Product p ON p.Product_Id = q.Product_Id WHERE q.Query_Id='" + querybal.Q_Id + "'";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }
        public int GiveReplyDetails(BAL.ProBAL querybal)
        {
            string qry = "UPDATE  Query SET Reply = '" + querybal.Reply + "' where Query_Id = '" + querybal.Q_Id + "'";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable MyQuery(BAL.ProBAL obj)
        {

            string qry2 = "select * from Query where User_Id=" + obj.login_id;
            SqlCommand cmd = new SqlCommand(qry2, GetCon());
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
    }
}