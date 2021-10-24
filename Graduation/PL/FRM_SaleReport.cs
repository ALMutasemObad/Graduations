using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class FRM_SaleReport : DevExpress.XtraEditors.XtraForm
    {

        BL.CLS_SAILES order = new BL.CLS_SAILES();
        DataTable d1 = new DataTable();
        DataTable dt = new DataTable();

        public FRM_SaleReport()
        {
            InitializeComponent();
        }

        public void txttotalSalesInTime()
        {
            txtTotalSales.Text = (from DataGridViewRow row in dgvAllSales.Rows
                                  where
                                      row.Cells[8].FormattedValue.ToString() != string.Empty
                                  select Convert.ToDouble(row.Cells[8].FormattedValue)).Sum().ToString();
        }

        private void radoBtnaAlUsers_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                d1.Clear();
                dgvAllSales.Refresh();
                txtTotalSales.Text = "";
                lkuSeachUsers.Visible = false;

                //dt = order.GetTotalSalesInTime(date1.Value,date2.Value);
                //dgvAllSales.DataSource = dt;
                //txttotalSalesInTime();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }


        }

        private void FRM_SaleReport_Load(object sender, EventArgs e)
        {
            DataTable dt = order.GetAllUsers();
            lkuSeachUsers.Properties.DataSource = dt;
            lkuSeachUsers.Properties.DisplayMember = "USER_NAME";
            lkuSeachUsers.Properties.ValueMember = "employee_number";
            lkuSeachUsers.Properties.PopulateColumns();
            lkuSeachUsers.Properties.Columns[2].Visible = false;


        }

        private void radoBtnSpUsers_CheckedChanged(object sender, EventArgs e)
        {
            lkuSeachUsers.Visible = true;
            dt.Clear();
            dgvAllSales.Refresh();
            txtTotalSales.Text = "";

        }

        private void lkuSeachUsers_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                dt.Clear();
                dgvAllSales.Refresh();
                txtTotalSales.Text = "";
                if (e.KeyCode == Keys.Enter && lkuSeachUsers.Text.Trim() != "")
                {
                    d1 = order.GetTotalSalesInTime1(date1.Value, date2.Value, lkuSeachUsers.Text);
                    dgvAllSales.DataSource = d1;
                    txttotalSalesInTime();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (radoBtnaAlUsers.Checked == true)
            {
                d1.Clear();
                dgvAllSales.Refresh();
                txtTotalSales.Text = "";
                lkuSeachUsers.Visible = false;

                dt = order.GetTotalSalesInTime(date1.Value, date2.Value);
                dgvAllSales.DataSource = dt;
                txttotalSalesInTime();
            }
            else if (radoBtnSpUsers.Checked == true)
            {
                dt.Clear();
                dgvAllSales.Refresh();
                txtTotalSales.Text = "";
                d1 = order.GetTotalSalesInTime1(date1.Value, date2.Value, lkuSeachUsers.Text);
                dgvAllSales.DataSource = d1;
                txttotalSalesInTime();
            }
            else
            {
                XtraMessageBox.Show("حدد المستخدم");
            }

        }
    }
}