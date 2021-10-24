using System;
using System.Data;
using System.Data.SqlClient;

namespace Graduation.BL
{
    class CLs_Item
    {


        public DataTable get_unit()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("Get_unit", null);

            DAL.Close();
            return dt;
        }


        public DataTable get_rowMaterial()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("selectAllRowMaterial", null);

            DAL.Close();
            return dt;
        }

        public DataTable get_item()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_item", null);

            DAL.Close();
            return dt;
        }

        public DataTable selectItem()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("selectItem", null);

            DAL.Close();
            return dt;
        }



        public DataTable get_item1(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@item_number", SqlDbType.Int);
            parm[0].Value = id;

            dt = DAL.SelectData("get_item2", parm);
            DAL.Close();
            return dt;
        }


        public DataTable get_item2(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@item_number", SqlDbType.Int);
            parm[0].Value = id;

            dt = DAL.SelectData("get_item1", parm);
            DAL.Close();
            return dt;
        }

        public DataTable get_store()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_store", null);

            DAL.Close();
            return dt;
        }

        public DataTable get_last_Item()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_last_Item", null);

            DAL.Close();
            return dt;
        }


        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_CATEGORIES", null);

            DAL.Close();
            return dt;
        }


        public DataTable getItemImage(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            // DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_IMAGE_PRODUCT", param);

            DAL.Close();
            return dt;
        }


        public void add_item(int id, string name, int cateID, bool activeM, bool activeS, int store,
       int unit, int itemQty, int mQty, bool prFrac, bool prDiscount, double salePric, double retailPrice, DateTime date, byte[] img)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[15];

            param[0] = new SqlParameter("@item_number", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@item_name", SqlDbType.VarChar, 50);
            param[1].Value = name;

            param[2] = new SqlParameter("@category_number", SqlDbType.Int);
            param[2].Value = cateID;

            param[3] = new SqlParameter("@is_active_made", SqlDbType.Bit);
            param[3].Value = activeM;

            param[4] = new SqlParameter("@is_active_sale", SqlDbType.Bit);
            param[4].Value = activeS;

            param[5] = new SqlParameter("@default_store", SqlDbType.Int);
            param[5].Value = store;

            param[6] = new SqlParameter("@unit_number", SqlDbType.Int);
            param[6].Value = unit;

            param[7] = new SqlParameter("@item_Qty", SqlDbType.Int);
            param[7].Value = itemQty;

            param[8] = new SqlParameter("@minimum_quantity", SqlDbType.Int);
            param[8].Value = mQty;

            param[9] = new SqlParameter("@prevent_fraction", SqlDbType.Bit);
            param[9].Value = prFrac;

            param[10] = new SqlParameter("@prevent_discount", SqlDbType.Bit);
            param[10].Value = prDiscount;

            param[11] = new SqlParameter("@wholePrice ", SqlDbType.Float);
            param[11].Value = salePric;

            param[12] = new SqlParameter("@retailPrice", SqlDbType.Float);
            param[12].Value = retailPrice;

            param[13] = new SqlParameter("@addDate", SqlDbType.DateTime);
            param[13].Value = date;

            param[14] = new SqlParameter("@itemImage", SqlDbType.Image);
            param[14].Value = img;

            DAL.ExcuteCommand("Insert_Item", param);
            DAL.Close();

        }



        public void add_item_Component(int id, int rowId, double qty, int unit)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@item_number", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@rowID", SqlDbType.Int);
            param[1].Value = rowId;

            param[2] = new SqlParameter("@qty ", SqlDbType.Float);
            param[2].Value = qty;

            param[3] = new SqlParameter("@unitId", SqlDbType.Int);
            param[3].Value = unit;



            DAL.ExcuteCommand("Insert_item_component", param);
            DAL.Close();

        }



        public void DeleteItem(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ID", SqlDbType.Int);
            parm[0].Value = ID;


            DAL.ExcuteCommand("DeleteItem  ", parm);
            DAL.Close();
        }


        public DataTable SearchItem(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            // DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SearchItem", param);

            DAL.Close();
            return dt;
        }
    }
}
