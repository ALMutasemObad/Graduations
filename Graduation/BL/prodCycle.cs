using System;
using System.Data;

namespace Graduation.BL
{
    class prodCycle : general
    {
        string tableName = "productionCycle";

        private void checkIfQuntityAvilable()
        {
            throw new NotImplementedException();
        }

        private void caculetTotalPrice()
        {
            throw new NotImplementedException();
        }

        private void decreasePrice()
        {
            throw new NotImplementedException();
        }

        private void increasePrice()
        {
            throw new NotImplementedException();
        }

        private void decreaseQuntity(int q)
        {
            throw new NotImplementedException();
        }

        private void increaseQuntity(int q)
        {
            throw new NotImplementedException();
        }

        internal DataTable getProductComPonents(int id, string quntity)
        {
            int q = int.Parse(quntity);


            DataTable dt = new DataTable();
            dt = dal.getProductDatils(id, q);
            dt.Columns[0].ColumnName = "المادة";
            dt.Columns[1].ColumnName = "كميته في المنتج (ملجم)";
            dt.Columns[2].ColumnName = "الكمية المطلوبة(لتر)";
            dt.Columns[3].ColumnName = "تكلفة المادة(ريال)";
            dt.Columns[4].ColumnName = "الكمية المتوفرة(لتر)";
            dt.Columns[5].ColumnName = "المعرف";





            return dt;
        }
        public void insert(int intcycle_Id, int product_Id, int quantity, DateTime productionDate, string totalCost)
        {
            DateTime date = productionDate;
            /*
             OleDbParameter[] param = new OleDbParameter[5];
              param[0] = addParameter("param0", OleDbType.Integer, date.);
              param[1] = addParameter("param1", OleDbType.Integer, product_Id);
              param[2] = addParameter("param2", OleDbType.Integer, quantity);
              param[3] = addParameter("param3", OleDbType.Date, date);
              param[4] = addParameter("param4", OleDbType.VarChar, totalCost);
              dal.insert(tableName, param);*/


            dal.insertProductionCycle(intcycle_Id, product_Id, quantity, date, totalCost);

            //updite QUANTITY of  product
            string q = dal.search("Item", "item_Qty", product_Id);
            if (q == "")
                q = "0";
            int intq = int.Parse(q);
            int Q = intq + quantity;
            dal.ubdate("Item", "item_Qty", Q, product_Id);


        }
        public void Update(int newq, int rawMatr_Id)
        {
            dal.ubdateR("ROW_MATERIALS", "QUANTITY", newq, rawMatr_Id);
        }
        internal DataTable getproductionCycle(int searchWord)
        {
            DataTable dt = new DataTable();
            dt = dal.getproductionCycle(searchWord);
            dt.Columns[0].ColumnName = "معرف الدورة ";
            dt.Columns[1].ColumnName = "اسم المنتج";
            dt.Columns[2].ColumnName = "كمية الانتاج";
            dt.Columns[3].ColumnName = "تاريخ الانتاج";
            dt.Columns[4].ColumnName = "تكلفة الانتاج";
            return dt;
        }


        internal void delete(int PCID, string productName, int pcQuantity)
        {
            ///////////////////////////////////////////////////////
            //الاستعلام عن رقم المنتج باستخدام الاسم 
            int product_Id = dal.findIdByName(productName, "product");
            //الاستعلام عن الكمية المتاحة من المنتج في المخزن
            string q = dal.search("product", "QUANTITY", product_Id);
            int intq = int.Parse(q);
            int Q = intq - pcQuantity;
            //تحديث الكمية المتوفرة من المنتج 
            dal.ubdate("product", "QUANTITY", Q, product_Id);
            //////////////////////////////////////////////////////////
            //تعديل كمية المواد الخام المتوفرة في المخزن
            DataTable dt = new DataTable();
            dt = getProductComPonents(product_Id, pcQuantity.ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int qRM = Convert.ToInt32(dt.Rows[i][4]);
                int qused = Convert.ToInt32(dt.Rows[i][2]);
                int idRM = Convert.ToInt32(dt.Rows[i][5]);
                int newQ = qRM + qused;
                Update(newQ, idRM);
            }
            /////////////////////////////////////////////////////////
            //حذف الدورة الانتاجية 
            dal.delet(tableName, PCID);

        }

        internal DataTable getproductionCycle(String searchWord)
        {



            DataTable dt = new DataTable();
            dt = dal.getproductionCycle(searchWord);
            dt.Columns[0].ColumnName = "معرف الدورة ";
            dt.Columns[1].ColumnName = "اسم المنتج";
            dt.Columns[2].ColumnName = "كمية الانتاج";
            dt.Columns[3].ColumnName = "تاريخ الانتاج";
            dt.Columns[4].ColumnName = "تكلفة الانتاج";






            return dt;
        }
        internal DataTable getproductionCycle()
        {

            DataTable dt = new DataTable();
            dt = dal.getproductionCycle();
            dt.Columns[0].ColumnName = "معرف الدورة ";
            dt.Columns[1].ColumnName = "اسم المنتج";
            dt.Columns[2].ColumnName = "كمية الانتاج";
            dt.Columns[3].ColumnName = "تاريخ الانتاج";
            dt.Columns[4].ColumnName = "تكلفة الانتاج";
            return dt;
        }
        internal DataTable searchByDateReng(DateTime from, DateTime to, string searchString)
        {
            string Sdate = from.ToString("dd/MM/yyyy");
            string Edate = to.ToString("dd/MM/yyyy");
            DataTable dt = new DataTable();
            dt = dal.qGetTableByDateReng(tableName, Sdate, Edate, searchString);
            dt.Columns[0].ColumnName = "معرف الدورة ";
            dt.Columns[1].ColumnName = "اسم المنتج";
            dt.Columns[2].ColumnName = "كمية الانتاج";
            dt.Columns[3].ColumnName = "تاريخ الانتاج";
            dt.Columns[4].ColumnName = "تكلفة الانتاج";
            return dt;
        }

    }
}

