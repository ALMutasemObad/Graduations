using System.Data;
using System.Data.SqlClient;
namespace Graduation.BL
{
    class CLS_unit
    {

        public DataTable get_last_unit()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("Get_Last_Unit", null);

            DAL.Close();
            return dt;
        }

        public void INSERT_Unit(int no,
         string unitname, string unitDetail)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[3];


            parm[0] = new SqlParameter("@unitNo", SqlDbType.Int);
            parm[0].Value = no;

            parm[1] = new SqlParameter("@unitName", SqlDbType.VarChar, 150);
            parm[1].Value = unitname;

            parm[2] = new SqlParameter("@unitDetail", SqlDbType.VarChar, 150);
            parm[2].Value = unitDetail;


            DAL.ExcuteCommand("INSERT_UNIT", parm);
            DAL.Close();
        }


        public DataTable Store_manager()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("Store_manager", null);

            DAL.Close();
            return dt;
        }

        public DataTable Get_Last_Store()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("Get_Last_Store", null);

            DAL.Close();
            return dt;
        }


        public void insert_to_store(int no,
      string storename, string strAddress, string strphone, string other, int strMgr)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[6];


            parm[0] = new SqlParameter("@strNumber", SqlDbType.Int);
            parm[0].Value = no;

            parm[1] = new SqlParameter("@strName", SqlDbType.VarChar, 150);
            parm[1].Value = storename;

            parm[2] = new SqlParameter("@strAddress", SqlDbType.VarChar, 150);
            parm[2].Value = strAddress;

            parm[3] = new SqlParameter("@strPhone", SqlDbType.VarChar, 20);
            parm[3].Value = strphone;

            parm[4] = new SqlParameter("@otherDetail", SqlDbType.VarChar, 150);
            parm[4].Value = other;

            parm[5] = new SqlParameter("@strManager", SqlDbType.Int);
            parm[5].Value = strMgr;


            DAL.ExcuteCommand("INSERT_To_Store", parm);
            DAL.Close();
        }
    }
}
