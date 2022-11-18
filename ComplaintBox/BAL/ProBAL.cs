using ComplaintBox.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace ComplaintBox.BAL
{
    public class ProBAL
    {
        DAL.ProDAL objprodal = new DAL.ProDAL();

        private string _Name;
        private string _PhoneNo;
        private string _Email;
        private string _password;
        private string _ProName;
        private string _price;
        private int _login;
        private int _proId;
        private int _cid;
        private int _qid;
        private string _complaint;
        private string _query;
        private string _toDate;
        private string _reply;
        private string _fromDate;
        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public string Phone_Number
        {
            get
            {
                return _PhoneNo;
            }
            set
            {
                _PhoneNo = value;
            }

        }
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }

        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }

        }
        public string Product_Name
        {
            get
            {
                return _ProName;
            }
            set
            {
                _ProName = value;
            }

        }
        public string Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }

        }
        public int login_id
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }

        }
        public int C_Id
        {
            get
            {
                return _cid;
            }
            set
            {
                _cid = value;
            }

        }
        public int Q_Id
        {
            get
            {
                return _qid;
            }
            set
            {
                _qid = value;
            }

        }
        public int ProductId
        {
            get
            {
                return _proId;
            }
            set
            {
                _proId = value;
            }
        }
        public string Complaint
        {
            get
            {
                return _complaint;
            }
            set
            {
                _complaint = value;
            }
        }
        public string ProductQuery
        {
            get
            {
                return _query;
            }
            set
            {
                _query = value;
            }
        }
        public string ToDate
        {
            get
            {
                return _toDate;
            }
            set
            {
                _toDate = value;
            }
        }
        public string FromDate
        {
            get
            {
                return _fromDate;
            }
            set
            {
                _fromDate = value;
            }
        }
        public String Reply
        {
            get
            {
                return _reply;
            }
            set
            {
                _reply = value;
            }
        }
        public int InsertStudent()
        {
            return objprodal.UserInsert(this);
        }
        public int LoginInsert()
        {
            return objprodal.InsertLogin(this);
        }
        public int ProductReg()
        {
            return objprodal.RegProd(this);
        }
        public DataTable viewUser()
        {
            return objprodal.UserView();
        }
        public int approveUser()
        {
            return objprodal.userApprove(this);
        }
        public DataTable LoginPage()
        {
            return objprodal.PageLogin(this);
        }
        public DataTable viewProd()
        {
            return objprodal.ProdView();
        }
        public DataSet viewproId()
        {
            return objprodal.ProdIdView();
        }
        public int InsertComplaint()
        {
            return objprodal.Complaint(this);
        }
        public int InsertQuery()
        {
            return objprodal.QueryInsert(this);
        }
        public DataTable GetProduct()
        {
            return objprodal.GetProDetails(this);
        }
        public DataTable viewComplaint()
        {
            return objprodal.ComplaintView(this);
        }
        public DataTable viewComplaintAll()
        {
            return objprodal.ComplaintViewAll(this);
        }
        public int StatusProgres()
        {
            return objprodal.ProgresStatus(this);
        }
        public int StatusClosed()
        {
            return objprodal.ClosedStatus(this);
        }
        public DataTable ComplaintClosed()
        {
            return objprodal.ClosedComplaint(this);
        }
        public DataTable viewMyself()
        {
            return objprodal.MyselfView(this);
        }
        public DataTable ViewQueries()
        {
            return objprodal.QueriesView(this);
        }
        public int GiveReply()
        {
            return objprodal.GiveReplyDetails(this);
        }
        public DataTable ViewSpecificQuery()
        {
            return objprodal.ViewSpecificQueryDetails(this);
        }
        public DataTable viewMyQuery()
        {
            return objprodal.MyQuery(this);
        }

    }
}