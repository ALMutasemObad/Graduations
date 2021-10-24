using System;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class FRM_OpenForm : DevExpress.XtraEditors.XtraForm
    {
        public FRM_OpenForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void showForms()
        {
            lbCount.Text = "يوجد" + (Application.OpenForms.Count - 1) + " شاشة مفتوحة";
            lbxTextForm.Items.Clear();
            lbxNameForm.Items.Clear();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "frmStart" || frm.Name == "FRM_MAIN") continue;
                lbxTextForm.Items.Add(frm.Text);
                lbxNameForm.Items.Add(frm.Name);
            }
        }
        private void FRM_OpenForm_Load(object sender, EventArgs e)
        {
            showForms();
        }

        private void lbxTextForm_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Application.OpenForms[lbxNameForm.Items[lbxTextForm.SelectedIndex].ToString()].Activate();
            }
            catch
            {
                return;
            }

        }

        private void btnRefreshOpenForms_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void cbxAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = cbxAutoRefresh.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            showForms();
        }
    }
}