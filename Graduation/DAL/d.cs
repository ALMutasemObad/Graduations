using System;
//using System.Data.OracleClient;
using System.Data;
using System.Data.OleDb;

namespace Graduation.DAL
{
    class d
    {

        public OleDbConnection con;
        public d()
        {
            con = new OleDbConnection(@"Provider=SQLNCLI11;Data Source=(LocalDb)\MSSQLLocalDB;Integrated Security=SSPI;Initial Catalog=master");
        }
        public void open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        internal void insertBond(int bondID, int customer_Id, string bandType, int valueBond, DateTime bondDate, DateTime tsdedDate, string valdity)
        {
            string date = tsdedDate.ToString();

            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.Connection = con;
            command.CommandText = "insert into  GUARANTEES  values( " + bondID + "," + customer_Id + "," + bandType + "," + valueBond + "," + bondDate + "," + date + "," + valdity + " )";
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        public DataTable selectAll(string tableName)
        {
            OleDbCommand command = new OleDbCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "select * from " + tableName;
            command.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public string selectMaxId(string tableName)
        {

            // ALTER TABLE bond RENAME COLUMN bond_id TO id;

            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select MAX(ID) as 'maxID' from " + tableName;
            command.Connection = con;
            con.Open();
            OleDbDataReader rd = command.ExecuteReader();

            string MaxId = "0";

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    MaxId = rd["maxID"].ToString();
                }

            }
            con.Close();
            return MaxId;




        }

        public string search(string tableName, string columName, string srchString)
        {
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from " + tableName + " where " + columName + " = '" + srchString + "'";
            command.Connection = con;
            con.Open();
            OleDbDataReader rd = command.ExecuteReader();
            string result = "nun";

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    result = rd[columName].ToString();
                }

            }
            con.Close();

            return result;

        }

        internal string search(string tableName, string columName, int id)
        {
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select  " + columName + " from " + tableName + " where item_number = " + id;
            command.Connection = con;
            con.Open();
            OleDbDataReader rd = command.ExecuteReader();
            string result = "nun";

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    result = rd[columName].ToString();
                }

            }
            con.Close();

            return result;
        }


        public void insert(string tableName, OleDbParameter[] param)
        {
            int n = 0;
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.Connection = con;

            if (param != null)
            {
                n = param.Length;
                command.Parameters.AddRange(param);
            }

            if (n == 3)
                command.CommandText = "insert into " + tableName + " values(:param0 ,:param1 ,:param2 )";
            else if (n == 4)
                command.CommandText = "insert into " + tableName + " values(:param0 ,:param1 ,:param2,param3 )";
            else if (n == 5)
                command.CommandText = "insert into " + tableName + " values(:param0 ,:param1 ,:param2,:param3,:param4 )";
            else if (n == 6)
                command.CommandText = "insert into " + tableName + " values(:param0 ,:param1 ,:param2,:param3,:param4,:param5 )";
            else if (n == 7)
                command.CommandText = "insert into " + tableName + " values(:param0 ,:param1 ,:param2,:param3,:param4,:param5,:param6 )";
            else if (n == 8)
                command.CommandText = "insert into " + tableName + " values(:param0 ,:param1 ,:param2,:param3,:param4,:param5,:param6,:param7 )";


            con.Open();
            command.ExecuteNonQuery();
            con.Close();

        }

        public void insertProductionCycle(int intID, int product_Id, int quantity, DateTime productionDate, string totalCost)
        {
            string date = productionDate.ToString();

            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.Connection = con;
            command.CommandText = "insert into  productionCycle  values( " + intID + "," + product_Id + "," + quantity + ",'" + date + "'," + totalCost + ")";
            con.Open();
            command.ExecuteNonQuery();
            con.Close();

        }

        internal void delet(string tableName, int ID)
        {
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from " + tableName + "  WHERE ID = " + ID;
            command.Connection = con;
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        internal DataTable qGetTableByDateReng(string tableName, string from, string to, string searchString)
        {
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = " select  C.Id ,P.productName ,C.quantity ,C.productionDate ,C.totalCost from productionCycle C, product P where C.product_Id=P.product_Id  and C.productionDate between '" + from + "' and '" + to + "' and P.productName like '%" + searchString + "%'";
            command.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        internal int findIdByName(string Name, string tableName)
        {
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select product_Id from " + tableName + " where PRODUCTNAME ='" + Name + "'";
            command.Connection = con;
            con.Open();
            OleDbDataReader rd = command.ExecuteReader();
            int Id = 0;
            while (rd.Read())
            {
                Id = Convert.ToInt32(rd["product_Id"]);
            }

            con.Close();
            return Id;
        }

        public DataTable selectWhere(string tableName, string[] colmnNames, OleDbParameter[] param)
        {
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            int n = 0;
            if (param != null)
            {
                n = param.Length;
                command.Parameters.AddRange(param);
            }
            if (n == 1)
                command.CommandText = "select * from " + tableName + " where " + colmnNames[0] + "=:param0 ";
            else if (n == 2)
                command.CommandText = "select * from " + tableName + " where " + colmnNames[0] + "=:param0 and " + colmnNames[1] + " =:param1";
            command.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public DataTable selectWhereId(string tableName, string[] colmnNames, OleDbParameter[] param)
        {
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            int n = 0;
            if (param != null)
            {
                n = param.Length;
                command.Parameters.AddRange(param);
            }

            command.CommandText = "select " + colmnNames[0] + " from " + tableName + " where id=:param0 ";

            command.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public DataTable searchD(string tableName, string columName, string srchString)
        {
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from " + tableName + " where " + columName + " like '%" + srchString + "%'";
            command.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        // public void delet(string tableName, string columName, int Id);
        public DataTable getProductDatils(int productId, int q)
        {


            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = " select R.SCIENTIFIC_NAME,I.Qty ,I.Qty*" + q + "/1000 , R.PRICE*I.Qty*" + q + "/1000 PRICE,R.QUANTITY,R.RowMaterial_ID  from ROW_MATERIALS R, Item_component I  Where R.RowMaterial_ID =I.rowMaterialID and I.item_number=" + productId;

            command.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public string max(string tableName, string colmnName)
        {
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select MAX(" + colmnName + ") from " + tableName;
            command.Connection = con;
            con.Open();
            OleDbDataReader rd = command.ExecuteReader();

            string Max = "";

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Max = rd["MAX(" + colmnName + ")"].ToString();
                }

            }
            con.Close();
            return Max;


        }
        public string min(string tableName, string colmnName)
        {
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select MIN(" + colmnName + ") from " + tableName;
            command.Connection = con;
            con.Open();
            OleDbDataReader rd = command.ExecuteReader();

            string min = "";

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    min = rd["MIN(" + colmnName + ")"].ToString();
                }

            }
            con.Close();
            return min;

        }
        public string count(string tableName)
        {

            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select COUNt(ID) from " + tableName;
            command.Connection = con;
            con.Open();
            OleDbDataReader rd = command.ExecuteReader();

            string count = "0";

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    count = rd["COUNt(ID)"].ToString();
                }

            }
            con.Close();
            return count;
        }
        public void ubdate(string tablName, string columnName, int newValue, int id)
        {
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = " UPDATE " + tablName + " SET " + columnName + " = " + newValue + " WHERE item_number = " + id;
            command.Connection = con;
            con.Open();
            command.ExecuteNonQuery();
            con.Close();


        }
        public void ubdateR(string tablName, string columnName, int newValue, int id)
        {
            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = " UPDATE " + tablName + " SET " + columnName + " = " + newValue + " WHERE RowMaterial_ID = " + id;
            command.Connection = con;
            con.Open();
            command.ExecuteNonQuery();
            con.Close();


        }
        public DataTable getproductionCycle(int CId)
        {


            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = " select  C.ID ,P.productName ,C.quantity ,C.productionDate ,C.totalCost from productionCycle C, product P where C.id=P.ID and C.ID=" + CId;
            command.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getproductionCycle(string pName)
        {


            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "  select  C.ID ,P.productName ,C.quantity ,C.productionDate ,C.totalCost from productionCycle C, product P where C.ID=P.ID and P.productName Like '%" + pName + "%'";
            command.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getproductionCycle()
        {


            OleDbCommand command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "  select  C.ID ,P.productName ,C.quantity ,C.productionDate ,C.totalCost from productionCycle C, product P where C.ID=P.ID ";
            command.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }




    }
}
