using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class frmStore : DevExpress.XtraEditors.XtraForm
    {
        public frmStore()
        {
            InitializeComponent();
        }



        BL.CLS_unit store = new BL.CLS_unit();



        private void ClearAndData()
        {
            DataTable tblEmp = store.Store_manager();
            cmbEmp.Properties.DataSource = tblEmp;
            cmbEmp.Properties.ValueMember = "employee_number";
            cmbEmp.Properties.DisplayMember = "employee_name";
            txtStoreNo.Text = store.Get_Last_Store().Rows[0][0].ToString();
            if (txtStoreNo.Text.Trim() == "") txtStoreNo.Text = "1";
            txtStoreName.Text = "";
            txtStoreAddress.Text = "";
            txtStorePhone.Text = "";
            cmbEmp.Text = "";
            txtStoreDetail.Text = "";
            txtStoreName.Select();



        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtStorePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void btnNewStore_Click(object sender, EventArgs e)
        {
            ClearAndData();
        }

        private void frmStore_Load(object sender, EventArgs e)
        {
            ClearAndData();
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            if (txtStoreNo.Text.Trim() == "")
            {
                XtraMessageBox.Show("اسم المخزن فارغ");
            }
            else if (txtStoreName.Text.Trim() == "")
            {
                XtraMessageBox.Show("اسم المخزن فارغ");
                txtStoreName.Select();
            }
            else if (txtStoreAddress.Text.Trim() == "")
            {
                XtraMessageBox.Show("عنوان المخزن فارغ");
                txtStoreAddress.Select();
            }
            else if (txtStorePhone.Text.Trim() == "")
            {
                XtraMessageBox.Show("هاتف المخزن فارغ");
                txtStorePhone.Select();
            }
            else if (cmbEmp.Text.Trim() == "")
            {
                XtraMessageBox.Show("مربع مدير المخزن فارغ ");
                cmbEmp.Select();
            }
            else if (txtStoreDetail.Text.Trim() == "")
            {
                XtraMessageBox.Show("الرجاء تعبئة مربع تفاصيل المخزن");
                txtStoreDetail.Select();
            }
            else
            {
                try
                {
                    store.insert_to_store(Convert.ToInt32(txtStoreNo.Text), txtStoreName.Text, txtStoreAddress.Text, txtStorePhone.Text, txtStoreDetail.Text, Convert.ToInt32(cmbEmp.EditValue));
                    XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "تم إضافة البيانات بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAndData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


    }
}