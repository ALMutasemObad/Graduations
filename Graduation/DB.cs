using System.Data;
using System.Data.SqlClient;

namespace Graduation
{
    class DB
    {
        public static SqlConnection conn = new SqlConnection(@"Provider=SQLNCLI10;Data Source=.\ZAID-COMPUTER;Integrated Security=SSPI;Initial Catalog=Graduation_DB");
        public static SqlCommand cmd = new SqlCommand("", conn);

        //public static void changeDBFile(string NewPathWithFileName)
        //{
        //    if (sqlconnection.State == ConnectionState.Closed)
        //    {
        //        sqlconnection.ConnectionString = "@Server=localhost;Database=" + NewPathWithFileName + ";Integrated Security=true";
        //    }
        //}


        public void Open()
        {

            if (conn.State != ConnectionState.Open)
            { conn.Open(); }
        }

        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            { conn.Close(); }
        }
        public static DataTable GetData(string Select)
        {


            cmd.CommandText = Select;
            cmd.Connection = conn;

            DataTable tb1 = new DataTable();
            tb1.Load(cmd.ExecuteReader());
            return tb1;

        }












    }
}
