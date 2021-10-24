using System;
using System.Data;
using System.Data.SqlClient;

namespace Graduation.BL
{
    class CLS_SAILES
    {



        public DataTable GET_LAST_ORDER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_LAST_ORDER_ID", null);

            DAL.Close();
            return dt;
        }

        public void ADD_ORDERS(int id, int cust_id, DateTime sale_date, double totalPrice, double payedvalue, double remainValue, DateTime pay_date,
            string user_id, string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[9];

            parm[0] = new SqlParameter("@sale_id", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@customer_id", SqlDbType.Int);
            parm[1].Value = cust_id;

            parm[2] = new SqlParameter("@sale_date", SqlDbType.DateTime);
            parm[2].Value = sale_date;

            parm[3] = new SqlParameter("@total_price", SqlDbType.VarChar, 30);
            parm[3].Value = totalPrice;

            parm[4] = new SqlParameter("@payed_value", SqlDbType.VarChar, 30);
            parm[4].Value = payedvalue;


            parm[5] = new SqlParameter("@remain_value", SqlDbType.VarChar, 30);
            parm[5].Value = remainValue;


            parm[6] = new SqlParameter("@pay_date", SqlDbType.Date);
            parm[6].Value = pay_date;

            parm[7] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            parm[7].Value = user_id;

            parm[8] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            parm[8].Value = Criterion;

            DAL.ExcuteCommand("add_order", parm);
            DAL.Close();
        }


        public DataTable sale_product(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = ID;
            dt = DAL.SelectData("sale_product", parm);
            DAL.Close();
            return dt;
        }


        public void addSaleDetails(int saleId, int itemID, string itemName,
   string unitId, int itemQty, double itmPrice, double amunt, int discount, double totalAmount, string usrName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@saleID", SqlDbType.Int);
            parm[0].Value = saleId;

            parm[1] = new SqlParameter("@itemIId", SqlDbType.Int);
            parm[1].Value = itemID;

            parm[2] = new SqlParameter("@item_name", SqlDbType.VarChar, 50);
            parm[2].Value = itemName;

            parm[3] = new SqlParameter("@unitName", SqlDbType.VarChar, 50);
            parm[3].Value = unitId;

            parm[4] = new SqlParameter("@itemQty", SqlDbType.Int);
            parm[4].Value = itemQty;

            parm[5] = new SqlParameter("@itemPrice", SqlDbType.Float);
            parm[5].Value = itmPrice;

            parm[6] = new SqlParameter("@amount", SqlDbType.Float);
            parm[6].Value = amunt;

            parm[7] = new SqlParameter("@discount", SqlDbType.Int);
            parm[7].Value = discount;

            parm[8] = new SqlParameter("@totalAmount", SqlDbType.Float);
            parm[8].Value = totalAmount;

            parm[9] = new SqlParameter("@userName", SqlDbType.VarChar, 50);
            parm[9].Value = usrName;


            DAL.ExcuteCommand("addSaileDetail", parm);
            DAL.Close();
        }
        public DataTable VerivyQty(int id, int QTE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@itemID", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@QteEntered", SqlDbType.Int);
            param[1].Value = QTE;

            // DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("VerivyQty", param);

            DAL.Close();
            return dt;
        }

        public DataTable GetTotalSalesInTime(DateTime date1, DateTime date2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date1", SqlDbType.DateTime);
            param[0].Value = date1;

            param[1] = new SqlParameter("@date2", SqlDbType.DateTime);
            param[1].Value = date2;

            // DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("TotalSalesInTime", param);

            DAL.Close();
            return dt;
        }

        public DataTable GetAllUsers()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GetAllUsers", null);

            DAL.Close();
            return dt;
        }
        public DataTable GetTotalSalesInTime1(DateTime date1, DateTime date2, string userName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@date1", SqlDbType.DateTime);
            param[0].Value = date1;

            param[1] = new SqlParameter("@date2", SqlDbType.DateTime);
            param[1].Value = date2;

            param[2] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param[2].Value = userName;
            // DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("TotalSalesInTime1", param);

            DAL.Close();
            return dt;
        }
    }

}
