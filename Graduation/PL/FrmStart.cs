using System;

namespace Graduation.PL
{
    public partial class FrmStart : DevExpress.XtraEditors.XtraForm
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {
            //new Frm_Login().Show();
            Frm_Login frm = new Frm_Login();
            frm.Show();
            DAL.DataAccessLayer db = new DAL.DataAccessLayer();
            db.Open();

        }
    }
}