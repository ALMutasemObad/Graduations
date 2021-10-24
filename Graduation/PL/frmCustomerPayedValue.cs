using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class frmCustomerPayedValue : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomerPayedValue()
        {
            InitializeComponent();
        }

        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();

        DataTable Customer = new DataTable();
        DataTable dt = new DataTable();
        void createICustomerDataTable()
        {
            Customer.Columns.Add("رقم الفاتورة");
            Customer.Columns.Add("المبلغ المتبقي");
            Customer.Columns.Add("العميل");
            Customer.Columns.Add("تاريخ الفاتورة");
            Customer.Columns.Add("تاريخ الأستحقاق");
            Customer.Columns.Add("النوع");
            dgvDelayCustomers.DataSource = Customer;

        }

        public void CalculateTotal()
        {
            txtTotalPayedValue.Text = (from DataGridViewRow row in dgvDelayCustomers.Rows
                                       where
                                           row.Cells[2].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();

        }

        private void radoBtnAllCustomer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalPayedValue.Text = "";
                Customer.Clear();
                dgvDelayCustomers.Refresh();

                lkuSearch.Visible = false;
                btnSearch.Visible = false;
                dt = cust.GetCustomer_PayedValue();

                dgvDelayCustomers.DataSource = dt;


                CalculateTotal();
            }
            catch
            {
                return;

            }
        }

        private void radoBtnSpecifiedCustomer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalPayedValue.Text = "";
                dt.Clear();
                dgvDelayCustomers.Refresh();
                lkuSearch.Visible = true;
                btnSearch.Visible = true;
            }
            catch
            {
                return;
            }

        }

        private void frmCustomerPayedValue_Load(object sender, EventArgs e)
        {
            DataTable c1 = cust.Get_Customers();
            lkuSearch.Properties.DataSource = c1;
            lkuSearch.Properties.DisplayMember = "CUSTOME_N";
            lkuSearch.Properties.ValueMember = "CUSTOMER_ID";
            lkuSearch.Properties.PopulateColumns();
            lkuSearch.Properties.Columns[0].Visible = false;

            radoBtnAllCustomer.Checked = true;
        }

        private void lkuSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && lkuSearch.Text != "" && radoBtnSpecifiedCustomer.Checked == true)
                {
                    DataTable Dt = cust.GetCustomer_PayedValue1(lkuSearch.Text);
                    dgvDelayCustomers.DataSource = Dt;


                    CalculateTotal();
                }
            }
            catch
            {
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable Dt = cust.GetCustomer_PayedValue1(lkuSearch.Text);
                dgvDelayCustomers.DataSource = Dt;


                CalculateTotal();

            }
            catch
            {
                return;
            }

        }
    }
}