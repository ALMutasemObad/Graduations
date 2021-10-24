using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class FRM_Employee : DevExpress.XtraEditors.XtraForm
    {

        BL.CLS_EMPLOYEE emp = new BL.CLS_EMPLOYEE();

        public FRM_Employee()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "أختر صورة";
            ofd.Filter = "Image|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    txtPathImage.Text = ofd.FileName;
                    Bitmap bmp = new Bitmap(Image.FromFile(ofd.FileName), new Size(100, 100));
                    picEmpImage.Image = bmp;
                }
            }
        }

        private void ClearAndAuto()
        {

            // txtEmpNum.Text = DB.GetData("select max(employee_number)+1 from employee").Rows[0][0].ToString();
            txtEmpNum.Text = emp.GET_LAST_employee().Rows[0][0].ToString();
            if (txtEmpNum.Text.Trim() == "") txtEmpNum.Text = "1";

            txtEmpName.Text = "";
            rdoMale.Checked = true;
            txtAddress.Text = "";
            txtNationNum.Text = "";
            txtPathImage.Text = "";
            picEmpImage.Image = new PictureBox().Image;


        }

        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            ClearAndAuto();
        }

        private void FRM_Employee_Load(object sender, EventArgs e)
        {
            ClearAndAuto();
        }






        private void txtNationNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] picture;

                if (txtEmpNum.Text.Trim() == "")
                {
                    MessageBox.Show("رقم الموظف فارغ");

                }
                else if (txtEmpName.Text.Trim() == "")
                {
                    MessageBox.Show("اسم الموظف فارغ");
                    txtEmpName.Select();
                }
                else if (txtAddress.Text.Trim() == "")
                {
                    MessageBox.Show("عنوان الموظف فارغ");
                    txtAddress.Select();
                }
                else if (txtNationNum.Text.Trim() == "")
                {
                    MessageBox.Show("الرقم القومي فارغ");
                    txtNationNum.Select();
                }
                else if (cbxQulification.Text.Trim() == "")
                {
                    MessageBox.Show("المؤهل فارغ");
                    cbxQulification.Select();
                }
                else if (cbxState.Text.Trim() == "")
                {
                    MessageBox.Show("الحالة الأجتماعية فارغ");
                    cbxState.Select();

                }
                else if (txtPathImage.Text.Trim() == "")
                {
                    MessageBox.Show("لابد من أختيار صورة ");
                }
                else if (txtPhone.Text.Trim() == "")
                {
                    MessageBox.Show("لابد من أختيار هاتف على الأقل ");
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    picEmpImage.Image.Save(ms, picEmpImage.Image.RawFormat);
                    picture = ms.ToArray();

                    emp.INSERT_Emp(Convert.ToInt32(txtEmpNum.Text), txtEmpName.Text, ((rdofmale.Checked) ? "ذكر" : "أنثى"),
                        txtAddress.Text, txtNationNum.Text, dtpBirthDate.DateTime, cbxQulification.Text, cbxState.Text, txtPhone.Text, picture);

                    MessageBox.Show("تمت الإضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}