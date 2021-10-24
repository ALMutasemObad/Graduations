using System;
using System.Data;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        private bool preventClose = true;


        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = preventClose;
            //Application.Exit();
        }




        private void Frm_Login_Load(object sender, EventArgs e)
        {
            this.Activate();


        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {

            BL.CLS_CUSTOMERS user = new BL.CLS_CUSTOMERS();

            DataTable tblLogin = new DataTable();
            try
            {
                tblLogin = user.SelectUser(txtUser.Text.Replace("'", ""), txtPass.Text.Replace("'", ""));
                if (tblLogin.Rows.Count < 1)
                {
                    MessageBox.Show("اسم المستخدم او كلمة المرور خطأ");
                }
                else
                {
                    FRM_MAIN frm = new FRM_MAIN();
                    v.UserName = tblLogin.Rows[0][0].ToString();
                    frm.Show();
                    preventClose = false;
                    this.Close();




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExist_Click_1(object sender, EventArgs e)
        {

            preventClose = false;
            Application.Exit();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtUser.Text != "")
            {
                btnEnter_Click_1(sender, e);
            }
        }


    }
}