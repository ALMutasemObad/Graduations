using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class frmItem : DevExpress.XtraEditors.XtraForm
    {

        BL.CLs_Item unit = new BL.CLs_Item();

        public static string txtItemId;
        string rwV;
        string rMu;

        public static string txtItemN;


        DataTable RwMat = new DataTable();

        DataTable Dt = new DataTable();



        void CreateDataTable()
        {
            Dt.Columns.Add("معرف المادة");
            Dt.Columns.Add("اسم المادة الخام");
            Dt.Columns.Add("النسبة");
            Dt.Columns.Add("معرف الوحدة");
            Dt.Columns.Add("اسم الوحدة");
            dgv.DataSource = Dt;
        }

        void ClearProductComponent()
        {
            lkUpSearchRowMaterial.Text = "";
            txtRwMQty.Text = "";
            lkRowMaterialUnit.Text = "";
        }
        public frmItem()
        {
            InitializeComponent();
            CreateDataTable();
        }




        private void ClearAndAuto()
        {
            DataTable tblUnit = unit.get_unit();
            cmbItemUnit.Properties.DataSource = tblUnit;
            cmbItemUnit.Properties.ValueMember = "unit_no";
            cmbItemUnit.Properties.DisplayMember = "unit_name";

            lkRowMaterialUnit.Properties.DataSource = tblUnit;
            lkRowMaterialUnit.Properties.ValueMember = "unit_no";
            lkRowMaterialUnit.Properties.DisplayMember = "unit_name";

            DataTable tblStore = unit.get_store();
            cmbItemStore.Properties.DataSource = tblStore;
            cmbItemStore.Properties.ValueMember = "store_number";
            cmbItemStore.Properties.DisplayMember = "store_name";

            RwMat = unit.get_rowMaterial();
            lkUpSearchRowMaterial.Properties.DataSource = RwMat;
            lkUpSearchRowMaterial.Properties.ValueMember = "RowMaterial_ID";
            lkUpSearchRowMaterial.Properties.DisplayMember = "SCIENTIFIC_NAME";

            DataTable dt = unit.GET_ALL_CATEGORIES();
            cmbCategories.Properties.DataSource = dt;
            cmbCategories.Properties.ValueMember = "category_number";
            cmbCategories.Properties.DisplayMember = "category_name";

            cmbItemUnit.Properties.PopulateColumns();
            lkRowMaterialUnit.Properties.PopulateColumns();
            cmbItemStore.Properties.PopulateColumns();
            lkUpSearchRowMaterial.Properties.PopulateColumns();
            cmbCategories.Properties.PopulateColumns();

            cmbItemUnit.Properties.Columns[0].Visible = false;
            lkRowMaterialUnit.Properties.Columns[0].Visible = false;
            cmbItemStore.Properties.Columns[0].Visible = false;
            lkUpSearchRowMaterial.Properties.Columns[0].Visible = false;
            cmbCategories.Properties.Columns[0].Visible = false;

            txtItemNumber.Text = unit.get_last_Item().Rows[0][0].ToString();
            if (txtItemNumber.Text.Trim() == "") txtItemNumber.Text = "1";
            txtItemName.Text = "";
            cmbCategories.Text = "";
            txtMiniQty.Text = "";
            chxPreventFraction.Checked = false;
            chxPrDiscount.Checked = false;
            chxActiveSale.Checked = true;
            chxActiveProduction.Checked = true;
            txtWhoePrice.Text = "";


            // pbox.Image = new PictureBox().Image;
            txtImagePath.Text = "";
            txtItemQty.Text = "";
            cmbCategories.Text = "";
            cmbItemStore.Text = "";
            cmbItemUnit.Text = "";
            txtItemName.Select();
            btnAddItem.Enabled = true;
            dgv.DataSource = null;


        }



        private void frmItem_Load(object sender, EventArgs e)
        {










        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "أختر صورة للصنف";
            ofd.Filter = " ملفات الصور |*.JPG; *.PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    txtImagePath.Text = ofd.FileName;

                    //Bitmap bmp = new Bitmap(Image.FromFile(ofd.FileName), new Size(100, 100));
                    //pbox.Image = bmp; 
                    pbox.Image = Image.FromFile(ofd.FileName);
                }

            }
        }


        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = true;
        }





        private void cmbItemStore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void cmbItemUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = true;
        }



        private void txtMiniQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtWholeSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtRetailSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            if (txtItemName.Text.Trim() == "")
            {
                XtraMessageBox.Show("اسم المنتج فارغ");
                txtItemName.Select();
            }


            else if (cmbCategories.Text.Trim() == "")
            {
                XtraMessageBox.Show("يرجاء ادخال صنف المنتج ");
                cmbCategories.Select();
            }
            else if (cmbItemStore.Text.Trim() == "")
            {
                XtraMessageBox.Show("يجب ان تضمن المخزن الذي سيتم تخزين المنتج فيه");
                cmbItemStore.Select();
            }
            else if (cmbItemUnit.Text.Trim() == "")
            {
                XtraMessageBox.Show("يرجاء ادخال وحدة قياس المنتج");
                cmbItemUnit.Select();
            }
            else if (txtItemQty.Text.Trim() == "")
            {
                XtraMessageBox.Show("يرجاء كمية المنتج");
                cmbItemUnit.Select();
            }
            else if (txtMiniQty.Text.Trim() == "")
            {
                XtraMessageBox.Show("يرجاء تحديد أقل كمية في المخزن");
                txtMiniQty.Select();
            }


            else if (txtWhoePrice.Text.Trim() == "")
            {
                XtraMessageBox.Show("يرجاء تحديد سعر المنتج بالجملة");
                txtWhoePrice.Select();
            }
            else if (txtRetailPrice.Text.Trim() == "")
            {
                XtraMessageBox.Show("يرجاء تحديد سعر المنتج بالتجزئة");
                txtWhoePrice.Select();
            }


            else if (txtImagePath.Text.Trim() == "")
            {
                XtraMessageBox.Show("يرجاء تحديد صورة المنتج");
                txtImagePath.Select();
            }
            else if (dgv.Rows.Count < 1)
            {
                XtraMessageBox.Show("يجب عليك تعبئة مكونات المنتج  من مواد الخام وكمياتها");
            }
            else
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();

                    unit.add_item(Convert.ToInt32(txtItemNumber.Text),
                        txtItemName.Text,
                        Convert.ToInt32(cmbCategories.EditValue),
                        chxActiveProduction.Checked,
                        chxActiveSale.Checked,
                        Convert.ToInt32(cmbItemStore.EditValue),
                        Convert.ToInt32(cmbItemUnit.EditValue), Convert.ToInt32(txtItemQty.Text),
                        Convert.ToInt32(txtMiniQty.Text),
                        chxPreventFraction.Checked, chxPrDiscount.Checked,
                        Convert.ToDouble(txtWhoePrice.Text), Convert.ToDouble(txtRetailPrice.Text), productionDate.Value, byteImage);
                    for (int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        unit.add_item_Component(Convert.ToInt32(txtItemNumber.Text), Convert.ToInt32(dgv.Rows[i].Cells[0].Value), Convert.ToInt32(dgv.Rows[i].Cells[2].Value), Convert.ToInt32(dgv.Rows[i].Cells[3].Value));

                    }
                    XtraMessageBox.Show("تمت عملية الحفظ بنجاح", " عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAndAuto();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            ClearAndAuto();
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (lkUpSearchRowMaterial.Text.Trim() == "")
            {
                XtraMessageBox.Show("أختر اسم المادة الخام ");
                lkUpSearchRowMaterial.Select();
            }

            else if (lkRowMaterialUnit.Text.Trim() == "")
            {
                XtraMessageBox.Show("حدد وحدة قياس المادة الخام ");
                lkRowMaterialUnit.Select();
            }

            else if (txtRwMQty.Text.Trim() == "")
            {
                XtraMessageBox.Show("حدد نسبة المادة الخام ");
                txtRwMQty.Select();
            }
            else
            {
                try
                {

                    rwV = Convert.ToString(lkUpSearchRowMaterial.EditValue);
                    rMu = Convert.ToString(lkRowMaterialUnit.EditValue);
                    string rmT = lkUpSearchRowMaterial.Text;
                    string rmuT = lkRowMaterialUnit.Text;

                    DataRow r = Dt.NewRow();
                    r[0] = rwV;
                    r[1] = rmT;
                    r[2] = txtRwMQty.Text;
                    r[3] = rMu;
                    r[4] = rmuT;

                    Dt.Rows.Add(r);
                    dgv.DataSource = Dt;


                    ClearProductComponent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void txtRwMQty_KeyDown(object sender, KeyEventArgs e)
        {



            if (e.KeyCode == Keys.Enter)
            {

                if (lkUpSearchRowMaterial.Text.Trim() == "")
                {
                    XtraMessageBox.Show("أختر اسم المادة الخام ");
                    lkUpSearchRowMaterial.Select();
                }

                else if (lkRowMaterialUnit.Text.Trim() == "")
                {
                    XtraMessageBox.Show("حدد وحدة قياس المادة الخام ");
                    lkRowMaterialUnit.Select();
                }

                else if (txtRwMQty.Text.Trim() == "")
                {
                    XtraMessageBox.Show("حدد نسبة المادة الخام ");
                    txtRwMQty.Select();
                }
                else
                {
                    try
                    {
                        for (int i = 0; i < dgv.Rows.Count - 1; i++)

                        {
                            if (Convert.ToInt32(dgv.Rows[i].Cells[0].Value) == Convert.ToInt32(lkUpSearchRowMaterial.EditValue))
                            {

                                XtraMessageBox.Show("هذا المادة الخام موجوده مسبقاً ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }

                        rwV = Convert.ToString(lkUpSearchRowMaterial.EditValue);
                        rMu = Convert.ToString(lkRowMaterialUnit.EditValue);
                        string rmT = lkUpSearchRowMaterial.Text;
                        string rmuT = lkRowMaterialUnit.Text;

                        DataRow r = Dt.NewRow();
                        r[0] = rwV;
                        r[1] = rmT;
                        r[2] = txtRwMQty.Text;
                        r[3] = rMu;
                        r[4] = rmuT;

                        Dt.Rows.Add(r);
                        dgv.DataSource = Dt;


                        ClearProductComponent();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void txtRwMQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
