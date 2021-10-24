using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class frmSaveAndPrintInvoice : DevExpress.XtraEditors.XtraForm
    {
        public frmSaveAndPrintInvoice()
        {
            InitializeComponent();
        }
        FRM_Orders frm = new FRM_Orders();
        private void frmSaveAndPrintInvoice_Load(object sender, EventArgs e)
        {

            txtRequestedValue.Text = v.requestedValue;

            txtPayedValue.Select();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPayedValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                double remain;
                remain = Convert.ToDouble(txtRequestedValue.Text) - Convert.ToDouble(txtPayedValue.Text);
                txtRemainedValue.Text = remain.ToString();
            }

        }

        private void btnSaveAndPrintInvoice_Click(object sender, EventArgs e)
        {

            v.payedValue = txtPayedValue.Text;
            v.RemainedValue = txtRemainedValue.Text;
            Close();

        }

        private void txtPayedValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }




    }
}