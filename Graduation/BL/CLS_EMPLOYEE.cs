using System;
using System.Data;
using System.Data.SqlClient;

namespace Graduation.BL
{
    class CLS_EMPLOYEE
    {

        public DataTable GET_LAST_employee()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_LAST_employee", null);

            DAL.Close();
            return dt;
        }



        public DataTable Select_Employee()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("Select_employee", null);

            DAL.Close();
            return dt;
        }


        public DataTable Select_employee_user()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("Select_employee_user", null);

            DAL.Close();
            return dt;
        }

        public void INSERT_Emp(int num,
            string name, string gender, string address, string ID, DateTime Bdate, string qualification, string state,
            string phone, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[10];


            parm[0] = new SqlParameter("@EMP_NUM", SqlDbType.Int);
            parm[0].Value = num;

            parm[1] = new SqlParameter("@EMP_NAME", SqlDbType.VarChar, 30);
            parm[1].Value = name;

            parm[2] = new SqlParameter("@GENDER", SqlDbType.VarChar, 8);
            parm[2].Value = gender;

            parm[3] = new SqlParameter("@ADDRESS", SqlDbType.VarChar, 30);
            parm[3].Value = address;

            parm[4] = new SqlParameter("@EMPNATIONnUM", SqlDbType.VarChar, 25);
            parm[4].Value = ID;

            parm[5] = new SqlParameter("@BirhDtae", SqlDbType.DateTime);
            parm[5].Value = Bdate;


            parm[6] = new SqlParameter("@qualification", SqlDbType.VarChar, 30);
            parm[6].Value = qualification;

            parm[7] = new SqlParameter("@employee_state", SqlDbType.VarChar, 30);
            parm[7].Value = state;

            parm[8] = new SqlParameter("@emp_phone", SqlDbType.VarChar, 15);
            parm[8].Value = phone;

            parm[9] = new SqlParameter("@emp_img", SqlDbType.Image);
            parm[9].Value = img;

            DAL.ExcuteCommand("INSERT_EMPLOYEE", parm);
            DAL.Close();
        }



        public void INSERT_User(string name,
           string pass, bool active, int num)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[4];


            parm[0] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            parm[0].Value = name;

            parm[1] = new SqlParameter("@pass", SqlDbType.VarChar, 8);
            parm[1].Value = pass;

            parm[2] = new SqlParameter("@is_active", SqlDbType.Bit);
            parm[2].Value = active;

            parm[3] = new SqlParameter("@emp_num", SqlDbType.Int);
            parm[3].Value = num;

            DAL.ExcuteCommand("Insert_user", parm);
            DAL.Close();
        }


        public void Update_User(string name,
          string pass, bool active)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[3];


            parm[0] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            parm[0].Value = name;

            parm[1] = new SqlParameter("@pass", SqlDbType.VarChar, 8);
            parm[1].Value = pass;

            parm[2] = new SqlParameter("@is_active", SqlDbType.Bit);
            parm[2].Value = active;



            DAL.ExcuteCommand("Update_user", parm);
            DAL.Close();
        }




        public void Delete_User(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[1];


            parm[0] = new SqlParameter("@userName", SqlDbType.VarChar, 50);
            parm[0].Value = name;




            DAL.ExcuteCommand("Delete_User", parm);
            DAL.Close();
        }




        //public void INSERT_EMPLOYEE_Imgae(int num, byte[] img)
        //{
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //    DAL.Open();
        //    SqlParameter[] parm = new SqlParameter[2];


        //    parm[0] = new SqlParameter("@EMP_NUM", SqlDbType.Int);
        //    parm[0].Value = num;

        //    parm[1] = new SqlParameter("@img", SqlDbType.Image);
        //    parm[1].Value = img;


        //    DAL.ExcuteCommand("INSERT_EMPLOYEE_Imgae", parm);
        //    DAL.Close();
        //}







    }
}
