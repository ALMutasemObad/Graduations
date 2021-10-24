using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Graduation.DAL
{
    class DataAccessLayer
    {
        BL.CLS_EMPLOYEE emp = new BL.CLS_EMPLOYEE();


        public static SqlConnection sqlconnection;

        //

        //this constructor inisialize the connection Object
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection(@"Data Source = (LocalDb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True");
        }


        // public static SqlCommand cmd = new SqlCommand("", sqlconnection);

        //public static void changeDBFile(string NewPathWithFileName)
        //{
        //    if (sqlconnection.State == ConnectionState.Closed)
        //    {
        //        sqlconnection.ConnectionString = "@Server=localhost;Database=" + NewPathWithFileName + ";Integrated Security=true";
        //    }
        //}
        // Method to open the connection
        public void Open()
        {

            if (sqlconnection.State != ConnectionState.Open)
            { sqlconnection.Open(); }
        }



        //Method to close the connection
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            { sqlconnection.Close(); }
        }



        //method to read Data from the database
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            //تنفيذ الكومند والحصول على نتيجتة وتمرير ال سكيول كومند الى ادابتر
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // AddAction(stored_procedure);
            return dt;
        }



        // Method to Insert, update and delete data frpm Database
        public void ExcuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
            // AddAction(stored_procedure);
        }

        //public static DataTable GetData(string Select)
        //{
        //    sqlconnection.Open();
        //    DataTable tb1 = new DataTable();
        //    cmd.CommandText = Select;
        //    tb1.Load(cmd.ExecuteReader());
        //    return tb1;
        //}

        //public static void Run(string SQL)
        //{

        //    cmd.CommandText = SQL;
        //    cmd.ExecuteNonQuery();
        //}

        public void InsertTo_proagram_action(string username, string AcDate, string AcTime, string frm_name, string opera_Name, string comp_name, string AcData)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] parm = new SqlParameter[7];


            parm[0] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            parm[0].Value = username;

            parm[1] = new SqlParameter("@action_date", SqlDbType.Date);
            parm[1].Value = AcDate;

            parm[2] = new SqlParameter("@action_time", SqlDbType.Time);
            parm[2].Value = AcTime;

            parm[3] = new SqlParameter("@form_name", SqlDbType.VarChar, 255);
            parm[3].Value = frm_name;

            parm[4] = new SqlParameter("@operation_name", SqlDbType.VarChar, 255);
            parm[4].Value = opera_Name;

            parm[5] = new SqlParameter("@computer_name", SqlDbType.VarChar, 255);
            parm[5].Value = comp_name;

            parm[6] = new SqlParameter("@action_data", SqlDbType.VarChar);
            parm[6].Value = AcData;


            DAL.ExcuteCommand("InsertTo_Program_Action", parm);
            DAL.Close();
        }


        public void AddAction(string SQL)
        {
            string username = v.UserName;
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string time = DateTime.Now.ToString("hh:mm:ss tt");
            Form frm = new Form();
            if (Application.OpenForms["FRM_MAIN"] != null)
                frm = Application.OpenForms["FRM_MAIN"].ActiveMdiChild;
            string formName = "";
            string operationName = " ";

            if (frm != null) formName = frm.Name + " , " + frm.Text;
            if (SQL.Length > 6)
            {
                if (SQL.Trim().Substring(0, 6).ToLower() == "select")
                    operationName = "أستعلام";
                else if (SQL.Trim().Substring(0, 6).ToLower() == "insert")
                    operationName = "إضافة";
                else if (SQL.Trim().Substring(0, 6).ToLower() == "update")
                    operationName = "تعديل";
                else if (SQL.Trim().Substring(0, 6).ToLower() == "delete")
                    operationName = "حذف";
            }
            string pcName = Environment.MachineName + " , " + Environment.UserName;
            string data = SQL.Trim().Replace("'", "''");
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.InsertTo_proagram_action(username, date, time, formName, operationName, pcName, data);




        }

        public DataTable selectAll(string tableName)
        {
            //OleDbCommand command = new OleDbCommand();
            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "select * from " + tableName;
            sqlcmd.Connection = sqlconnection;
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //public string selectMaxId(string tableName)
        //{
        //    // ALTER TABLE bond RENAME COLUMN bond_id TO id;

        //    //OleDbCommand command = new OleDbCommand();
        //    SqlCommand sqlcmd = new SqlCommand();
        //    sqlcmd.CommandType = CommandType.Text;
        //    sqlcmd.CommandText = "select MAX(ID) from " + tableName;
        //    sqlcmd.Connection = sqlconnection;
        //    sqlconnection.Open();

        //    SqlDataAdapter rd = sqlcmd.ExecuteReader();

        //    string MaxId = "0";

        //    if (rd.)
        //    {
        //        while (rd.Read())
        //        {
        //            MaxId = rd["MAX(ID)"].ToString();
        //        }

        //    }
        //    sqlconnection.Close();
        //    return MaxId;


        //}
    }
}

