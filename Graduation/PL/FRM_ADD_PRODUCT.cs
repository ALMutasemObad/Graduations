using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class FRM_ADD_PRODUCT : DevExpress.XtraEditors.XtraForm
    {
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
            cmbCategories.Properties.DataSource = prd.GET_ALL_CATEGORIES();
            cmbCategories.Properties.DisplayMember = "category_number";
            cmbCategories.Properties.ValueMember = "category_name";

            //cmbCategories.Properties.PopulateColumns();
            // cmbCategories.Properties.Columns[0].Visible=true;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " ملفات الصور |*.JPG; *.PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteImage = ms.ToArray();

                prd.ADD_PRODUCT(Convert.ToInt32(txtRef.Text), Convert.ToInt32(cmbCategories.EditValue),
                    txtDes.Text, txtQte.Text,
                    cmbMeasure.Text,
                    txtSize.Text, textEdit6.Text,
                     txtPrice1.Text, txtPrice2.Text, txtNote.Text,
                    dateTimePicker1.Value,
                    txtSize.Text, byteImage);

                MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRef_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.VerifyProductID(txtRef.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("هذا المعرف موجود مسبقاً", "تبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRef.Focus();
                txtRef.SelectionStart = 0;
                //txtRef.SelectionLength = txtRef.TextLength;
            }

        }


    }
}