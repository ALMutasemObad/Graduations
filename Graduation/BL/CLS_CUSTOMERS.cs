using System;
using System.Data;
using System.Data.SqlClient;

namespace Graduation.BL
{
    class CLS_CUSTOMERS
    {



        public DataTable SelectUser(string username, string password)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@uname", SqlDbType.VarChar, 50);
            parm[0].Value = username;

            parm[1] = new SqlParameter("@pass", SqlDbType.VarChar, 8);
            parm[1].Value = password;
            dt = DAL.SelectData("SelectUser", parm);
            DAL.Close();
            return dt;
        }


        public void ADD_CUSTOMER(string name,
            string ID_Card, string address, string phon, string Ctype, byte[] Img, string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[7];


            parm[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            parm[0].Value = name;

            parm[1] = new SqlParameter("@ID_CARD", SqlDbType.VarChar, 15);
            parm[1].Value = ID_Card;

            parm[2] = new SqlParameter("@ADDRESS", SqlDbType.VarChar, 50);
            parm[2].Value = address;

            parm[3] = new SqlParameter("@PHONE", SqlDbType.NChar, 15);
            parm[3].Value = phon;

            parm[4] = new SqlParameter("@CUSTOMER_TYPE", SqlDbType.VarChar, 20);
            parm[4].Value = Ctype;


            parm[5] = new SqlParameter("@IMG", SqlDbType.Image);
            parm[5].Value = Img;

            parm[6] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            parm[6].Value = Criterion;

            DAL.ExcuteCommand("ADD_CUSTOMER", parm);
            DAL.Close();
        }



        public void EDIT_CUSTOMER(string name,
            string ID_Card, string address, string phon, string Ctype, byte[] Img, string Criterion, int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[8];



            parm[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            parm[0].Value = name;

            parm[1] = new SqlParameter("@ID_CARD", SqlDbType.VarChar, 15);
            parm[1].Value = ID_Card;

            parm[2] = new SqlParameter("@ADDRESS", SqlDbType.VarChar, 50);
            parm[2].Value = address;

            parm[3] = new SqlParameter("@PHONE", SqlDbType.NChar, 15);
            parm[3].Value = phon;

            parm[4] = new SqlParameter("@CUSTOMER_TYPE", SqlDbType.VarChar, 20);
            parm[4].Value = Ctype;


            parm[5] = new SqlParameter("@IMG", SqlDbType.Image);
            parm[5].Value = Img;

            parm[6] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            parm[6].Value = Criterion;

            parm[7] = new SqlParameter("@ID", SqlDbType.Int);
            parm[7].Value = ID;

            DAL.ExcuteCommand("EDIT_CUSTOMER", parm);
            DAL.Close();

        }


        public void DELETE_CUSTOMER(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[1];


            parm[0] = new SqlParameter("@ID", SqlDbType.Int);
            parm[0].Value = ID;


            DAL.ExcuteCommand("DELETE_CUSTOMER", parm);
            DAL.Close();
        }


        public DataTable GET_ALL_CUSTOMERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_CUSTOMERS", null);

            DAL.Close();
            return dt;

        }


        public DataTable Get_Customers()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Get_Customers", null);

            DAL.Close();
            return dt;

        }

        public DataTable Search_Customer(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;
            dt = DAL.SelectData("Search_Customer", param);

            DAL.Close();
            return dt;

        }


        public DataTable GetDelayCustomer()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetAllCustomer_daley", null);

            DAL.Close();
            return dt;

        }

        public DataTable GetDelayCustomer1(int Id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = Id;
            dt = DAL.SelectData("GetAllCustomer_daley1", param);

            DAL.Close();
            return dt;

        }
        public void UpdateCutomer_Delay(int ID, string remainvalue)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[2];


            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = ID;

            parm[1] = new SqlParameter("@remainValue", SqlDbType.VarChar, 30);
            parm[1].Value = remainvalue;

            DAL.ExcuteCommand("UpdateCutomer_Delay", parm);
            DAL.Close();
        }

        public void addPayedValue(int ID, string custId, string payedVallue, DateTime date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@saleID", SqlDbType.Int);
            parm[0].Value = ID;

            parm[1] = new SqlParameter("@CustomerId", SqlDbType.VarChar, 50);
            parm[1].Value = custId;

            parm[2] = new SqlParameter("@payedValue", SqlDbType.VarChar, 30);
            parm[2].Value = payedVallue;

            parm[3] = new SqlParameter("@date", SqlDbType.DateTime);
            parm[3].Value = date;

            DAL.ExcuteCommand("addPayedValue", parm);
            DAL.Close();
        }


        public DataTable GetCustomer_PayedValue()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetCustomer_PayedValue", null);

            DAL.Close();
            return dt;

        }
        public DataTable GetCustomer_PayedValue1(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = name;
            dt = DAL.SelectData("GetCustomer_PayedValue1", param);

            DAL.Close();
            return dt;

        }

    }
}
