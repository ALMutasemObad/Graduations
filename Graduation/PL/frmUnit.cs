using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class frmUnit : DevExpress.XtraEditors.XtraForm
    {


        BL.CLS_unit unit = new BL.CLS_unit();
        public frmUnit()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void ClearAndAuto()
        {
            txtUnitN.Text = unit.get_last_unit().Rows[0][0].ToString();
            if (txtUnitN.Text.Trim() == "") txtUnitN.Text = "1";
            txtUnitName.Text = "";
            txtUnitDetail.Text = "";
            txtUnitName.Select();


        }
        private void frmUnit_Load(object sender, EventArgs e)
        {
            ClearAndAuto();
        }

        private void btnNewUnit_Click(object sender, EventArgs e)
        {
            ClearAndAuto();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            if (txtUnitN.Text.Trim() == "")
            {
                XtraMessageBox.Show("رقم الوحدة فارغ رالجع مصمم البرنامج");
            }
            else if (txtUnitName.Text.Trim() == "")
            {
                XtraMessageBox.Show("أسم الوحدة فارغ");
            }
            else if (txtUnitDetail.Text.Trim() == "")
            {
                XtraMessageBox.Show("تفاصيل الوحدة فارغ");
            }
            else
            {
                try
                {
                    unit.INSERT_Unit(Convert.ToInt32(txtUnitN.Text), txtUnitName.Text, txtUnitDetail.Text);
                    XtraMessageBox.Show("تم إضافة الوحدة بنجاح");
                    ClearAndAuto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}