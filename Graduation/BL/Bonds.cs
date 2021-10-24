using System;
using System.Data;

namespace Graduation.BL
{
    class Bonds : general
    {

        DataTable dt = new DataTable();
        internal DataTable customerInfo(string customerName)
        {
            string tableName = "customer";
            string columnName = "fullName";

            dt = dal.searchD(tableName, columnName, customerName);
            return dt;
        }

        internal void addTheBond(int bondID, int customer_Id, string bandType, int valueBond, DateTime bondDate, DateTime tsdedDate, string valdity)
        {
            dal.insertBond(bondID, customer_Id, bandType, valueBond, bondDate, tsdedDate, valdity);
        }
    }
}
