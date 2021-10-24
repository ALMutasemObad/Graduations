using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class FRM_CUSTOMER_AC : DevExpress.XtraEditors.XtraForm
    {
        public FRM_CUSTOMER_AC()
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
            txtTotalRemainedValue.Text = (from DataGridViewRow row in dgvDelayCustomers.Rows
                                          where
                                              row.Cells[1].FormattedValue.ToString() != string.Empty
                                          select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum().ToString();

        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void FRM_CUSTOMER_AC_Load(object sender, EventArgs e)
        {
            //createICustomerDataTable();

            DataTable c1 = cust.Get_Customers();
            lkuSearch.Properties.DataSource = c1;
            lkuSearch.Properties.DisplayMember = "CUSTOME_N";
            lkuSearch.Properties.ValueMember = "CUSTOMER_ID";
            lkuSearch.Properties.PopulateColumns();
            lkuSearch.Properties.Columns[0].Visible = false;

            radoBtnAllCustomer.Checked = true;
        }

        private void radoBtnAllCustomer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalRemainedValue.Text = "";
                Customer.Clear();
                dgvDelayCustomers.Refresh();

                lkuSearch.Visible = false;
                btnSearch.Visible = false;
                dt = cust.GetDelayCustomer();

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
            txtTotalRemainedValue.Text = "";
            dt.Clear();
            dgvDelayCustomers.Refresh();
            lkuSearch.Visible = true;
            btnSearch.Visible = true;




        }

        private void lkuSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && lkuSearch.Text != "" && radoBtnSpecifiedCustomer.Checked == true)
                {
                    DataTable Dt = cust.GetDelayCustomer1(Convert.ToInt32(lkuSearch.EditValue));
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

                DataTable Dt = cust.GetDelayCustomer1(Convert.ToInt32(lkuSearch.EditValue));
                dgvDelayCustomers.DataSource = Dt;
                CalculateTotal();


            }
            catch
            {
                return;
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            double remain;
            double payment;
            if (radoBtnPaymentPart.Checked == true)
            {


                remain = Convert.ToDouble(dgvDelayCustomers.CurrentRow.Cells[1].Value);
                payment = Convert.ToDouble(txtPayment.Text);
                if (remain != 0)
                {
                    string r = Convert.ToString(remain - payment);
                    dgvDelayCustomers.CurrentRow.Cells[1].Value = r;

                    cust.addPayedValue(Convert.ToInt32(dgvDelayCustomers.CurrentRow.Cells[0].Value),
                        dgvDelayCustomers.CurrentRow.Cells[2].Value.ToString(),
                        txtPayment.Text,
                         System.DateTime.Now);

                    cust.UpdateCutomer_Delay(Convert.ToInt32(dgvDelayCustomers.CurrentRow.Cells[0].Value), r);
                    CalculateTotal();
                    XtraMessageBox.Show("تم عملية التسديد بنجاح");
                }
                else
                {
                    XtraMessageBox.Show("لقد تم تسديد هذا المبلغ وقيمته الآن(0)");
                }

            }
            else if (radoBtnPaymentAll.Checked == true)
            {


                payment = Convert.ToDouble(dgvDelayCustomers.CurrentRow.Cells[1].Value);
                if (payment != 0)
                {
                    string r = Convert.ToString(payment - payment);
                    dgvDelayCustomers.CurrentRow.Cells[1].Value = r;
                    cust.addPayedValue(Convert.ToInt32(dgvDelayCustomers.CurrentRow.Cells[0].Value),
                        dgvDelayCustomers.CurrentRow.Cells[2].Value.ToString(),
                        Convert.ToString(payment),
                        System.DateTime.Now);

                    cust.UpdateCutomer_Delay(Convert.ToInt32(dgvDelayCustomers.CurrentRow.Cells[0].Value), r);
                    CalculateTotal();
                    XtraMessageBox.Show("تم عملية التسديد بنجاح");
                }

                else
                {
                    XtraMessageBox.Show("لقد تم تسديد هذا المبلغ وقيمته الآن(0)");
                }
            }



        }

        private void radoBtnPaymentAll_CheckedChanged(object sender, EventArgs e)
        {
            txtPayment.Visible = false;
        }

        private void radoBtnPaymentPart_CheckedChanged(object sender, EventArgs e)
        {
            txtPayment.Visible = true;
        }


    }
}