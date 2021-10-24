using System;
using System.Data;
using System.Data.SqlClient;

namespace Graduation.BL
{
    class CLS_PRODUCTS
    {



        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_CATEGORIES", null);

            DAL.Close();
            return dt;
        }







        public void ADD_PRODUCT(int PRODUCT_ID, int ID_CAT, string PRODUCT_NAME, string QTY_IN_STOCK, string MEASURE_UNIT,
            string SIZE, string PRODUCT_validity, string RETAIL_PRICE, string WHOLE_PRICE, string DESCRIPTION, DateTime ADD_DATE, string DEMAND_SIZE, byte[] PRODUCT_IMAGE)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@PRODUCT_ID", SqlDbType.Int);
            param[0].Value = PRODUCT_ID;

            param[1] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[1].Value = ID_CAT;

            param[2] = new SqlParameter("@PRODUCT_NAME", SqlDbType.VarChar, 50);
            param[2].Value = PRODUCT_NAME;

            param[3] = new SqlParameter("@QTY_IN_STOCK", SqlDbType.VarChar, 50);
            param[3].Value = QTY_IN_STOCK;

            param[4] = new SqlParameter("@MEASURE_UNIT", SqlDbType.VarChar, 50);
            param[4].Value = MEASURE_UNIT;

            param[5] = new SqlParameter("@SIZE", SqlDbType.VarChar, 30);
            param[5].Value = SIZE;

            param[6] = new SqlParameter("@PRODUCT_validity", SqlDbType.VarChar, 50);
            param[6].Value = PRODUCT_validity;

            param[7] = new SqlParameter("@RETAIL_PRICE", SqlDbType.VarChar, 50);
            param[7].Value = RETAIL_PRICE;

            param[8] = new SqlParameter("@WHOLE_PRICE", SqlDbType.VarChar, 50);
            param[8].Value = WHOLE_PRICE;

            param[9] = new SqlParameter("@DESCRIPTION", SqlDbType.VarChar, 50);
            param[9].Value = DESCRIPTION;

            param[10] = new SqlParameter("@ADD_DATE", SqlDbType.DateTime);
            param[10].Value = ADD_DATE;

            param[11] = new SqlParameter("@DEMAND_SIZE", SqlDbType.VarChar, 20);
            param[11].Value = DEMAND_SIZE;

            param[12] = new SqlParameter("@PRODUCT_IMAGE", SqlDbType.Image);
            param[12].Value = PRODUCT_IMAGE;

            DAL.ExcuteCommand("ADD_PRODUCT", param);
            DAL.Close();

        }

        public DataTable VerifyProductID(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 30);
            param[0].Value = id;


            //    DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("VerifyProductID", param);

            DAL.Close();
            return dt;
        }


        public DataTable GET_ALL_PRODUCTS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();

            dt = DAL.SelectData("GET_ALL_PRODUCTS", null);

            DAL.Close();
            return dt;
        }
    }

}
