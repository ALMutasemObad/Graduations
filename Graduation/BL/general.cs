using System;
using System.Data;
using System.Data.OleDb;
namespace Graduation.BL
{
    class general
    {
        public DAL.d dal = new DAL.d();

        public DataTable qGetTable(string tableName)
        {
            DataTable dt = new DataTable();
            dt = dal.selectAll(tableName);
            return dt;
        }

        public int qGetNextId(string tableName)
        {
            string MaxId = dal.selectMaxId(tableName);
            if (MaxId == "")
                MaxId = "0";
            int nextId = int.Parse(MaxId);
            nextId += 1;
            return nextId;
        }


        public bool checkIfExsast(string tableName, string columName, string stringSearch)
        {
            bool Rslt;
            string result = dal.search(tableName, columName, stringSearch);
            if (result != "nun")
                Rslt = true;
            else
                Rslt = false;
            return Rslt;
        }
        public bool checkIfNull(string val1)
        {
            if (val1 == null)
                return true;
            else
                return false;
        }
        public OleDbParameter addParameter(string ParameterName, OleDbType type, string value)
        {
            OleDbParameter param = new OleDbParameter();
            param.ParameterName = ParameterName;
            param.OleDbType = type;

            param.Value = value;
            return param;
        }
        public OleDbParameter addParameter(string ParameterName, OleDbType type, int value)
        {
            OleDbParameter param = new OleDbParameter();
            param.ParameterName = ParameterName;
            param.OleDbType = type;
            param.Value = value;
            return param;
        }
        public OleDbParameter addParameter(string ParameterName, OleDbType type, byte[] value)
        {
            OleDbParameter param = new OleDbParameter();
            param.ParameterName = ParameterName;
            param.OleDbType = type;
            param.Value = value;
            return param;
        }
        public OleDbParameter addParameter(string ParameterName, OleDbType type, DateTime value)
        {
            OleDbParameter param = new OleDbParameter();
            param.ParameterName = ParameterName;
            param.OleDbType = type;
            param.Value = value;
            return param;
        }
        public bool pravlig(string form, string elimnt, string atrbute, string userId)
        {
            if (userId == "1")
                return false;
            else return true;
        }


    }
}
