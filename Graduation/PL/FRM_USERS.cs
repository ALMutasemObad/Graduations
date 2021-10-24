using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class FRM_USERS : DevExpress.XtraEditors.XtraForm
    {
        BL.CLS_EMPLOYEE emp = new BL.CLS_EMPLOYEE();

        public FRM_USERS()
        {
            InitializeComponent();
        }



        DataTable tblUser = new DataTable();

        private void ShowData()
        {
            tblUser.Clear();
            tblUser = emp.Select_employee_user();
            dgvUsers.DataSource = tblUser;
        }

        private void ClearData()
        {
            dgvUsers.ClearSelection();
            DataTable tblEmp = emp.Select_Employee();
            cmbEmp.Properties.DataSource = tblEmp;
            cmbEmp.Properties.ValueMember = "employee_number";
            cmbEmp.Properties.DisplayMember = "employee_name";
            cmbEmp.Properties.PopulateColumns();
            cmbEmp.Properties.Columns[0].Visible = false;
            cmbEmp.Text = "";
            txtUserName.Text = "";
            txtPassWord.Text = "";

            rdoActive.Checked = true;
            btnAddUser.Enabled = true;
            txtUserName.Enabled = true;

            btnEditUser.Enabled = false;
            btnDeleteUser.Enabled = false;
            txtUserName.Select();

        }


        private void FRM_USERS_Load(object sender, EventArgs e)
        {
            try
            {
                ShowData();
                ClearData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
            if (cmbEmp.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء أختيار موظف من القائمة");
            }
            else if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء أدخال أسم المستخدم");
            }
            else if (txtPassWord.Text.Trim() == "")
            {
                MessageBox.Show("كلمة المرور فارغــة");
            }
            else
            {
                try
                {
                    //DAL.DataAccessLayer.Run("insert into Users values('" + txtUserName.Text.Replace("'", "") + "','" + txtPassWord.Text.Replace("'", "") + "','" + ((rdoActive.Checked) ? true : false) + "'," + cmbEmp.EditValue + ")");
                    emp.INSERT_User(txtUserName.Text, txtPassWord.Text, ((rdoActive.Checked) ? true : false), Convert.ToInt32(cmbEmp.EditValue));
                    XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "تم إضافة البيانات بنجاح", "العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // MessageBox.Show("تم إضافة البيانات بنجاح");
                    ClearData();
                    ShowData();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        XtraMessageBox.Show("أدخل أسم مستخدم مختلف لأن هذا موجود");
                        txtUserName.Text = "";
                        txtUserName.Select();
                    }
                    else
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            string strPatt = "";
            if (rdoEmployee.Checked) strPatt += "employee_name";
            else if (rdoUser.Checked) strPatt += "User_Name";

            strPatt += " like'%" + txtSearch.Text + "%' ";

            strPatt += " and  ";

            if (cbxActive.CheckState.ToString().ToLower() == "checked")
            {
                strPatt += " is_active in ('True')";
            }
            else if (cbxActive.CheckState.ToString().ToLower() == "unchecked")
            {
                strPatt += " is_active in ('False')";
            }
            else
            {
                strPatt += " is_active in ('True','False')";
            }

            DataView dv = new DataView(tblUser);
            dv.RowFilter = strPatt;
            dgvUsers.DataSource = dv;

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("هل تريد حذف هذا المستخدم", "رسالة تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {

                    emp.Delete_User(txtUserName.Text);

                    XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "تم حـــذف المستخدم بنجاح", "تأكيد عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowData();

                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            dgvUsers.Columns[3].Visible = cbxShowPassword.Checked;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {


            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء أدخال أسم المستخدم");
            }
            else if (txtPassWord.Text.Trim() == "")
            {
                MessageBox.Show("كلمة المرور فارغــة");
            }
            else
            {
                try
                {
                    //DAL.DataAccessLayer.Run("insert into Users values('" + txtUserName.Text.Replace("'", "") + "','" + txtPassWord.Text.Replace("'", "") + "','" + ((rdoActive.Checked) ? true : false) + "'," + cmbEmp.EditValue + ")");
                    emp.Update_User(txtUserName.Text, txtPassWord.Text, ((rdoActive.Checked) ? true : false));
                    XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "تم تعديل البيانات بنجاح", "العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // MessageBox.Show("تم إضافة البيانات بنجاح");
                    ClearData();
                    ShowData();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        XtraMessageBox.Show("أدخل أسم مستخدم مختلف لأن هذا موجود");
                        txtUserName.Text = "";
                        txtUserName.Select();
                    }
                    else
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvUsers.CurrentRow != null)
            {
                cmbEmp.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
                txtUserName.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
                txtPassWord.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
                if ((bool)dgvUsers.CurrentRow.Cells[4].Value)
                    rdoActive.Checked = true;
                else
                    rdoNotActive.Checked = true;

                btnAddUser.Enabled = false;
                txtUserName.Enabled = false;
                btnEditUser.Enabled = true;
                btnDeleteUser.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxActive_CheckStateChanged(object sender, EventArgs e)
        {
            txtSearch_EditValueChanged(null, null);
        }


    }
}