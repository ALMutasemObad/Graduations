using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class frmItemShow : DevExpress.XtraEditors.XtraForm
    {
        BL.CLs_Item unit = new BL.CLs_Item();

        BL.CLs_Item item = new BL.CLs_Item();
        DataTable tbleAllproduct = new DataTable();
        public frmItemShow()
        {
            InitializeComponent();
            // CreateDataTable();
        }

        DataTable dt = new DataTable();
        void CreateDataTable()
        {
            dt.Columns.Add("معرف الصنف");
            dt.Columns.Add("اسم الصنف");
            dt.Columns.Add("التصنيف");
            dt.Columns.Add("فعال التصنيع");
            dt.Columns.Add("فعال البيع");
            dt.Columns.Add("الوحدة");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("حد النوقص");
            dt.Columns.Add("منع بيع كسور");
            dt.Columns.Add("منع خصم");
            dt.Columns.Add("سعر الجملة");
            dt.Columns.Add(" سعر التجزئة");
            dt.Columns.Add("تاريخ الإضافة");
            dgvProducts.DataSource = dt;
        }

        private void frmItemShow_Load(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = item.get_item();
            lkeSearchItems.Properties.DataSource = Dt;
            lkeSearchItems.Properties.ValueMember = "item_number";
            lkeSearchItems.Properties.DisplayMember = "item_name";

            lkeSearchItems.Properties.PopulateColumns();
            lkeSearchItems.Properties.Columns[0].Visible = false;
            lkeSearchItems.Properties.Columns[2].Visible = false;
            lkeSearchItems.Properties.Columns[3].Visible = false;


        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {

        }


        public void calculateReferences()
        {
            try
            {
                txtQty.Text = (from DataGridViewRow row in dgvProducts.Rows
                               where
                                   row.Cells[6].FormattedValue.ToString() != string.Empty
                               select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

                txtWholePrice.Text = (from DataGridViewRow row in dgvProducts.Rows
                                      where
                                          row.Cells[10].FormattedValue.ToString() != string.Empty
                                      select Convert.ToDouble(row.Cells[10].FormattedValue)).Sum().ToString();
                txtRetailPrice.Text = (from DataGridViewRow row in dgvProducts.Rows
                                       where
                                           row.Cells[11].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[11].FormattedValue)).Sum().ToString();

            }
            catch
            {
                return;
            }



        }
        DataTable dt1 = new DataTable();
        private void btnAdd2_Click(object sender, EventArgs e)
        {



            try
            {
                if (lkeSearchItems.Text.Trim() != "")
                {
                    dt1 = item.get_item1(Convert.ToInt32(lkeSearchItems.EditValue));

                    //string itId = dt1.Rows[0]["item_number"].ToString();
                    //string itN = dt1.Rows[0]["item_name"].ToString();
                    //string itCat = dt1.Rows[0]["category_number"].ToString();
                    //string itIsMade = dt1.Rows[0]["is_active_made"].ToString();
                    //string itIsActve = dt1.Rows[0]["is_active_sale"].ToString();
                    //string itUni = dt1.Rows[0]["unit_name"].ToString();
                    //string itQty = dt1.Rows[0]["item_Qty"].ToString();
                    //string itMnQty = dt1.Rows[0]["minimum_quantity"].ToString();
                    //string preFr = dt1.Rows[0]["prevent_fraction"].ToString();
                    //string preDis = dt1.Rows[0]["prevent_discount"].ToString();
                    //string whPrice = dt1.Rows[0]["whole_price"].ToString();
                    //string rePrice = dt1.Rows[0]["retail_price"].ToString();
                    //string addDate = dt1.Rows[0]["AddDate"].ToString();


                    //for (int i = 0; i < dgvProducts.Rows.Count - 1; i++)
                    //{
                    //    if (dgvProducts.Rows[i].Cells[0].Value.ToString() == Convert.ToString(lkeSearchItems.EditValue))
                    //    {
                    //        XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "هذا المنتج موجود مسبقاً في  القائمة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //        // MessageBox.Show("هذا المنتج موجود مسبقاً", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //        return;
                    //    }

                    //}

                    //DataRow r = dt.NewRow();

                    //r[0] = itId;
                    //r[1] = itN;
                    //r[2] = itCat;
                    //r[3] = itIsMade;
                    //r[4] = itIsActve;
                    //r[5] = itUni;
                    //r[6] = itQty;
                    //r[7] = itMnQty;
                    //r[8] = preFr;
                    //r[9] = preDis;
                    //r[10] = whPrice;
                    //r[11] = rePrice;
                    //r[12] = addDate;
                    //dt.Rows.Add(r);

                    dgvProducts.DataSource = dt1;
                    calculateReferences();
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

        private void btnViewAllProducts_Click(object sender, EventArgs e)
        {
            try
            {

                tbleAllproduct = item.selectItem();
                //dgvProducts.DataSource = null;
                dgvProducts.DataSource = tbleAllproduct;
                calculateReferences();
            }
            catch
            {
                return;
            }

        }



        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            frmItem frm = new frmItem();
            frm.ShowDialog();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            frmItem frm = new frmItem();
            frm.txtItemNumber.Text = Convert.ToInt32(this.dgvProducts.CurrentRow.Cells[0].Value).ToString();
            frm.txtItemName.Text = this.dgvProducts.CurrentRow.Cells[1].Value.ToString();

            frm.cmbCategories.Text = this.dgvProducts.CurrentRow.Cells[2].Value.ToString();
            frm.chxActiveProduction.Checked = Convert.ToBoolean(this.dgvProducts.CurrentRow.Cells[3].Value);
            frm.chxActiveSale.Checked = Convert.ToBoolean(this.dgvProducts.CurrentRow.Cells[4].Value);
            frm.cmbItemUnit.Text = this.dgvProducts.CurrentRow.Cells[5].Value.ToString();
            frm.txtItemQty.Text = this.dgvProducts.CurrentRow.Cells[6].Value.ToString();
            frm.txtMiniQty.Text = this.dgvProducts.CurrentRow.Cells[7].Value.ToString();
            frm.chxPreventFraction.Checked = Convert.ToBoolean(this.dgvProducts.CurrentRow.Cells[8].Value);
            frm.chxPrDiscount.Checked = Convert.ToBoolean(this.dgvProducts.CurrentRow.Cells[9].Value);
            frm.txtWhoePrice.Text = this.dgvProducts.CurrentRow.Cells[10].Value.ToString();
            frm.txtRetailPrice.Text = this.dgvProducts.CurrentRow.Cells[11].Value.ToString();
            frm.productionDate.Value = Convert.ToDateTime(this.dgvProducts.CurrentRow.Cells[12].Value);
            frm.Text = "تحديث المنتوج:" + this.dgvProducts.CurrentRow.Cells[1].Value.ToString();
            frm.btnAddItem.Text = "تحديث ";
            byte[] image = (byte[])item.getItemImage(Convert.ToInt32(this.dgvProducts.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pbox.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void btnDeleteSpecificProduct_Click(object sender, EventArgs e)
        {
            {
                if (XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "هل تريد حذف المنتج المحدد", " تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    item.DeleteItem(Convert.ToInt32(this.dgvProducts.CurrentRow.Cells[0].Value));
                    XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "تم حـــذف الصنف بنجاح", "تأكيد عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvProducts.DataSource = item.selectItem();
                }
                else
                {
                    MessageBox.Show("تمت إلغاء عملية الحذف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FRM_Catogreis frm = new FRM_Catogreis();
            frm.ShowDialog();
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable Dt = new DataTable();
                Dt = item.SearchItem(txtSearch.Text);
                this.dgvProducts.DataSource = Dt;
                calculateReferences();
            }
            catch
            {
                return;
            }

        }

        private void lkeSearchItems_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && lkeSearchItems.Text.Trim() != "")
                {
                    btnAdd2_Click(sender, e);
                }
            }
            catch
            {
                return;
            }


        }


    }
}