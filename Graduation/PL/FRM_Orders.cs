using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class FRM_Orders : DevExpress.XtraEditors.XtraForm
    {
        BL.CLS_SAILES sale = new BL.CLS_SAILES();
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        BL.CLs_Item itemCLs = new BL.CLs_Item();

        DataTable dt = new DataTable();

        DataTable Dt = new DataTable();

        DataTable item = new DataTable();
        DataTable item2 = new DataTable();

        DataTable tblItem = new DataTable();



        void createItemDataTable()
        {
            item.Columns.Add("المعرف");
            item.Columns.Add("اسم المنتج");
            item.Columns.Add("الوحدة");
            item.Columns.Add("الكمية");
            item.Columns.Add("السعر");
            item.Columns.Add("المبلغ");
            item.Columns.Add("نسبة الخصم (%)");
            item.Columns.Add("الأجمالي");
            dgv.DataSource = item;
            
        }

        string sumTotal;


        void CalculateAmount()
        {
            //if (txtPrice.Text != "" && txtQty.Text != "")
            //{
            //    double Amount = (Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQty.Text));

            //    txtAmount.Text = Amount.ToString();
            //}
        }


        void CalculateTotalAmount()
        {
            //if (txtDiscount.Text != string.Empty && txtAmount.Text != string.Empty)
            //{
            //    double Discount = Convert.ToDouble(txtDiscount.Text);
            //    double Amount = Convert.ToDouble(txtAmount.Text);
            //    double TotalAmount = Amount - (Amount * (Discount / 100));

            //    txtTotalAmount.Text = TotalAmount.ToString();
            //}

        }


        void ResizeDGV()
        {
            //this.dgvProducts.RowHeadersWidth = 55;
            //this.dgvProducts.Columns[0].Width = 50;
            //this.dgvProducts.Columns[1].Width = 200;
            //this.dgvProducts.Columns[2].Width = 105;
            //this.dgvProducts.Columns[3].Width = 77;
            //this.dgvProducts.Columns[4].Width = 93;
            //this.dgvProducts.Columns[5].Width = 85;
            //this.dgvProducts.Columns[6].Width = 30;
        }



        public FRM_Orders()
        {
            InitializeComponent();



        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMER frm = new FRM_CUSTOMER();
            frm.Show();
        }



        private void FRM_Orders_Load(object sender, EventArgs e)
        {


            createItemDataTable();
            this.txtOrderId.Text = sale.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            dt = cust.Get_Customers();
            txtSearch.Properties.DataSource = dt;
            txtSearch.Properties.DisplayMember = "CUSTOME_N";
            txtSearch.Properties.ValueMember = "CUSTOMER_ID";
            txtSearch.Properties.PopulateColumns();
            txtSearch.Properties.Columns[0].Visible = false;

            txtSaleMan.Text = v.UserName;


            tblItem = itemCLs.get_item();
            lKUpSearchItem.Properties.DataSource = tblItem;
            lKUpSearchItem.Properties.ValueMember = "item_number";
            lKUpSearchItem.Properties.DisplayMember = "item_name";
            lKUpSearchItem.Properties.PopulateColumns();
            lKUpSearchItem.Properties.Columns[0].Visible = false;
            radBtnDirectCustomer.Checked = true;

            // TODO: This line of code loads data into the 'graduation_DBDataSet1.GET_ALL_CUSTOMERS' table. You can move, or remove it, as needed.
            this.gET_ALL_CUSTOMERSTableAdapter.Fill(this.graduation_DBDataSet1.GET_ALL_CUSTOMERS);
            // TODO: This line of code loads data into the 'graduation_DBDataSet.ChooseProduct' table. You can move, or remove it, as needed.
            this.chooseProductTableAdapter.Fill(this.graduation_DBDataSet.ChooseProduct);

        }

        void calu()
        {


            //if (txtSumTotal.Text != "" && txtPayedValue.Text != "")
            //{
            //    txtRemainValue.Clear();
            //    double Amount = (Convert.ToDouble(txtSumTotal.Text) - Convert.ToDouble(txtPayedValue.Text));

            //    txtRemainValue.Text = Amount.ToString();

            //}

        }

        private void txtPayedValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtSumTotal.Text != "")
            {

                calu();
            }
        }

        BL.CLS_SAILES order = new BL.CLS_SAILES();


        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Close();

        }




        private void radBtnDirectCustomer_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            btnAddCust.Visible = false;
            labelControl3.Visible = false;
            pay_date.Visible = false;
            v.b1 = true;
            //txtRemainValue.Text = "0";
            //txtPayedValue.ReadOnly = true;


        }

        private void radBtnNotDirectCustomer_CheckedChanged(object sender, EventArgs e)
        {
            btnAddCust.Visible = true;
            txtSearch.Visible = true;
            labelControl3.Visible = true;
            pay_date.Visible = true;

            v.b1 = false;
            //txtRemainValue.Text = "";
            //txtPayedValue.Text = "";
            // txtPayedValue.ReadOnly = false;


        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {

            try
            {
                if (lKUpSearchItem.Text.Trim() != "")
                {

                    //if (order.VerivyQty(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value), Convert.ToInt32(dgv.CurrentRow.Cells[3].Value)).Rows.Count < 1)
                    //{

                    //    MessageBox.Show("الكمية المدخلة لهذا المنتج غير متاحة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    //return;

                    //}
                    item2 = itemCLs.get_item2(Convert.ToInt32(lKUpSearchItem.EditValue));

                    string itemId = item2.Rows[0]["item_number"].ToString();

                    string itemName = item2.Rows[0]["item_name"].ToString();
                    string itemUnit = item2.Rows[0]["unit_name"].ToString();
                    string itemPrice = item2.Rows[0]["whole_price"].ToString();
                    int QtY = 1;
                    double Amount = Convert.ToDouble(QtY) * Convert.ToDouble(itemPrice);
                    double discount = 0.0;
                    double TotalAmount = Amount - (Amount * (discount / 100));


                    for (int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        if (dgv.Rows[i].Cells[0].Value.ToString() == Convert.ToString(lKUpSearchItem.EditValue))
                        {
                            XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "هذا المنتج موجود مسبقاً في  القائمة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            // MessageBox.Show("هذا المنتج موجود مسبقاً", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                    }

                    DataRow r = item.NewRow();

                    r[0] = itemId;
                    r[1] = itemName;
                    r[2] = itemUnit;
                    r[3] = QtY;
                    r[4] = itemPrice;
                    r[5] = Amount;
                    r[6] = discount;
                    r[7] = TotalAmount;
                    item.Rows.Add(r);

                    dgv.DataSource = item;

                    txtSumTotal.Text = (from DataGridViewRow row in dgv.Rows
                                        where
                                            row.Cells[7].FormattedValue.ToString() != string.Empty
                                        select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();


                }
                else
                {
                    XtraMessageBox.Show("يجب عليك أختيار منتج من مربع البحث");
                }


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }
        DataTable tbledit = new DataTable();

        void calculateTotalAmount()
        {

            string price1 = dgv.CurrentRow.Cells[4].Value.ToString();
            string Qty = dgv.CurrentRow.Cells[3].Value.ToString();
            string disco = dgv.CurrentRow.Cells[6].Value.ToString();
            double price2;

            if (price1 != "")
            {
                price2 = Convert.ToDouble(price1) * Convert.ToInt32(Qty);

                dgv.CurrentRow.Cells[5].Value = price2;

                dgv.CurrentRow.Cells[7].Value = price2 - (price2 * (Convert.ToDouble(disco) / 100));


                txtSumTotal.Text = (from DataGridViewRow row in dgv.Rows
                                    where
                                        row.Cells[7].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            }
            else
            {
                XtraMessageBox.Show("يجب عليك تعبئة مكونات المنتج  من مواد الخام وكمياتها");
                return;

            }




        }


        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                v.discount = this.dgv.CurrentRow.Cells[6].Value.ToString();
                v.price = this.dgv.CurrentRow.Cells[4].Value.ToString();
                v.unit = this.dgv.CurrentRow.Cells[2].Value.ToString();
                v.Qty = this.dgv.CurrentRow.Cells[3].Value.ToString();
                if (dgv.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    PL.FRM_SAVE_SALE edit = new FRM_SAVE_SALE();
                    edit.ShowDialog();
                    dgv.CurrentRow.Cells[6].Value = v.discount;
                    dgv.CurrentRow.Cells[4].Value = v.price;
                    dgv.CurrentRow.Cells[2].Value = v.unit;
                    dgv.CurrentRow.Cells[3].Value = v.Qty;
                    calculateTotalAmount();
                }
                else
                {
                    XtraMessageBox.Show("يجب عليك تعبئة البيانات الى القائمة");
                }
            }
            catch
            {
                return;
            }





        }

        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            txtSumTotal.Text = (from DataGridViewRow row in dgv.Rows
                                where
                                    row.Cells[7].FormattedValue.ToString() != string.Empty
                                select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_DoubleClick(sender, e);
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try { dgv.Rows.RemoveAt(dgv.CurrentRow.Index); }
            catch
            {
                return;
            }
        }

        private void حذفالكلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                item.Clear();
                dgv.Refresh();
            }
            catch
            {
                return;
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            حذفToolStripMenuItem_Click(sender, e);
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F11)
            {

                v.discount = this.dgv.CurrentRow.Cells[6].Value.ToString();
                v.price = this.dgv.CurrentRow.Cells[4].Value.ToString();
                v.unit = this.dgv.CurrentRow.Cells[2].Value.ToString();
                v.Qty = this.dgv.CurrentRow.Cells[3].Value.ToString();
                if (dgv.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    PL.FRM_SAVE_SALE edit = new FRM_SAVE_SALE();
                    edit.ShowDialog();
                    dgv.CurrentRow.Cells[6].Value = v.discount;
                    dgv.CurrentRow.Cells[4].Value = v.price;
                    dgv.CurrentRow.Cells[2].Value = v.unit;
                    dgv.CurrentRow.Cells[3].Value = v.Qty;
                    calculateTotalAmount();
                }
                else
                {
                    XtraMessageBox.Show("يجب عليك تعبئة البيانات الى القائمة");
                }
            }

            else if (e.KeyCode == Keys.F12)
            {
                v.requestedValue = txtSumTotal.Text;
                frmSaveAndPrintInvoice frm = new frmSaveAndPrintInvoice();
                frm.ShowDialog();

                try
                {
                    if (radBtnNotDirectCustomer.Checked == true)
                    {

                        order.ADD_ORDERS(Convert.ToInt32(txtOrderId.Text), Convert.ToInt32(txtSearch.EditValue), sale_date.Value, Convert.ToDouble(txtSumTotal.Text),
                          Convert.ToDouble(v.payedValue), Convert.ToDouble(v.RemainedValue), pay_date.Value, txtSaleMan.Text, "عميل آجل");

                        for (int i = 0; i < dgv.Rows.Count - 1; i++)
                        {
                            order.addSaleDetails(Convert.ToInt32(txtOrderId.Text), Convert.ToInt32(dgv.Rows[i].Cells[0].Value),
                                dgv.Rows[i].Cells[1].Value.ToString(),
                                dgv.Rows[i].Cells[2].Value.ToString(),
                              Convert.ToInt32(dgv.Rows[i].Cells[3].Value),
                                Convert.ToDouble(dgv.Rows[i].Cells[4].Value),
                               Convert.ToDouble(dgv.Rows[i].Cells[5].Value),
                               Convert.ToInt32(dgv.Rows[i].Cells[6].Value),
                              Convert.ToDouble(dgv.Rows[i].Cells[7].Value),
                              txtSaleMan.Text);
                        }
                        cust.addPayedValue(Convert.ToInt32(txtOrderId.Text), txtSearch.Text, v.payedValue, System.DateTime.Now);

                        XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "تمت عملية الحفظ والإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (radBtnDirectCustomer.Checked == true)
                    {

                        order.ADD_ORDERS(Convert.ToInt32(txtOrderId.Text), Convert.ToInt32(txtSearch.EditValue), sale_date.Value,
                            Convert.ToDouble(txtSumTotal.Text), Convert.ToDouble(v.payedValue), Convert.ToDouble(v.RemainedValue),
                             pay_date.Value, txtSaleMan.Text, "عميل نقدي");

                        for (int i = 0; i < dgv.Rows.Count - 1; i++)
                        {
                            order.addSaleDetails(Convert.ToInt32(txtOrderId.Text),
                                Convert.ToInt32(dgv.Rows[i].Cells[0].Value),
                                 dgv.Rows[i].Cells[1].Value.ToString(),
                                dgv.Rows[i].Cells[2].Value.ToString(),
                              Convert.ToInt32(dgv.Rows[i].Cells[3].Value),
                                Convert.ToDouble(dgv.Rows[i].Cells[4].Value),
                               Convert.ToDouble(dgv.Rows[i].Cells[5].Value),
                               Convert.ToInt32(dgv.Rows[i].Cells[6].Value),
                              Convert.ToDouble(dgv.Rows[i].Cells[7].Value),
                              txtSaleMan.Text);

                        }

                        XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "تمت الإضافلة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    return;

                }


            }

        }


        //private void FRM_Orders_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.F12 && txtSumTotal.Text.Trim() == "")
        //    {
        //        XtraMessageBox.Show("يرجاء أدخال اصناف الى القائمة");
        //    }
        //    else
        //    {
        //        v.requestedValue = txtSumTotal.Text;
        //        frmSaveAndPrintInvoice frm = new frmSaveAndPrintInvoice();
        //        frm.ShowDialog();
        //    }
        //}

        private void حفظوطباعةالفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (txtSumTotal.Text.Trim() == "")
            {
                XtraMessageBox.Show("يرجاء أدخال اصناف الى القائمة");
            }
            else
            {
                v.requestedValue = txtSumTotal.Text;
                frmSaveAndPrintInvoice frm = new frmSaveAndPrintInvoice();
                frm.ShowDialog();
                try
                {
                    if (radBtnNotDirectCustomer.Checked == true)
                    {

                        order.ADD_ORDERS(Convert.ToInt32(txtOrderId.Text), Convert.ToInt32(txtSearch.EditValue), sale_date.Value, Convert.ToDouble(txtSumTotal.Text),
                          Convert.ToDouble(v.payedValue), Convert.ToDouble(v.RemainedValue), pay_date.Value, txtSaleMan.Text, "عميل آجل");

                        for (int i = 0; i < dgv.Rows.Count - 1; i++)
                        {
                            order.addSaleDetails(Convert.ToInt32(txtOrderId.Text), Convert.ToInt32(dgv.Rows[i].Cells[0].Value),
                                dgv.Rows[i].Cells[1].Value.ToString(),
                                dgv.Rows[i].Cells[2].Value.ToString(),
                              Convert.ToInt32(dgv.Rows[i].Cells[3].Value),
                                Convert.ToDouble(dgv.Rows[i].Cells[4].Value),
                               Convert.ToDouble(dgv.Rows[i].Cells[5].Value),
                               Convert.ToInt32(dgv.Rows[i].Cells[6].Value),
                              Convert.ToDouble(dgv.Rows[i].Cells[7].Value),
                              txtSaleMan.Text);
                        }
                        cust.addPayedValue(Convert.ToInt32(txtOrderId.Text), txtSearch.Text, v.payedValue, System.DateTime.Now);

                        XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "تمت عملية الحفظ والإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (radBtnDirectCustomer.Checked == true)
                    {

                        order.ADD_ORDERS(Convert.ToInt32(txtOrderId.Text), Convert.ToInt32(txtSearch.EditValue), sale_date.Value,
                            Convert.ToDouble(txtSumTotal.Text), Convert.ToDouble(v.payedValue), Convert.ToDouble(v.RemainedValue),
                             pay_date.Value, txtSaleMan.Text, "عميل نقدي");

                        for (int i = 0; i < dgv.Rows.Count - 1; i++)
                        {
                            order.addSaleDetails(Convert.ToInt32(txtOrderId.Text),
                                Convert.ToInt32(dgv.Rows[i].Cells[0].Value),
                                 dgv.Rows[i].Cells[1].Value.ToString(),
                                dgv.Rows[i].Cells[2].Value.ToString(),
                              Convert.ToInt32(dgv.Rows[i].Cells[3].Value),
                                Convert.ToDouble(dgv.Rows[i].Cells[4].Value),
                               Convert.ToDouble(dgv.Rows[i].Cells[5].Value),
                               Convert.ToInt32(dgv.Rows[i].Cells[6].Value),
                              Convert.ToDouble(dgv.Rows[i].Cells[7].Value),
                              txtSaleMan.Text);

                        }

                        XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "تمت الإضافلة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    return;
                }

            }
        }

        private void lKUpSearchItem_EditValueChanged(object sender, EventArgs e)
        {
            btnAddItems_Click(sender, e);
        }

        private void lKUpSearchItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < dgv.Rows.Count - 1; i++)
                {
                    if (dgv.Rows[i].Cells[0].Value.ToString() == Convert.ToString(lKUpSearchItem.EditValue))
                    {
                        XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "هذا المنتج موجود مسبقاً في  القائمة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        // MessageBox.Show("هذا المنتج موجود مسبقاً", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                btnAddItems_Click(sender, e);

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.txtOrderId.Text = sale.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            lKUpSearchItem.Text = "";
            txtSearch.Text = "";
            حذفالكلToolStripMenuItem1_Click(sender, e);
        }









    }
}


