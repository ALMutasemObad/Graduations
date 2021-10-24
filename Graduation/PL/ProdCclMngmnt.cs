using System;
using System.Data;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class ProdCclMngmnt : DevExpress.XtraEditors.XtraForm
    {
        BL.prodCycle PC = new BL.prodCycle();
        string searchWord;
        DataTable dt = new DataTable();
        public ProdCclMngmnt()
        {
            InitializeComponent();


            dateSearchGroupBox.Visible = false;
        }

        private void ProdCclMngmnt_Load(object sender, EventArgs e)
        {

            dt = PC.getproductionCycle();
            dataGridView.DataSource = dt;
            if (dt.Rows.Count <= 0)
                resultGroupBox.Enabled = false;

        }

        private void dateCheckBox_Click(object sender, EventArgs e)
        {
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("هل تريد الخروج من ادارة الدورات الانتاجية ؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Close();
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void IDsearchControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IDsearchControl_TextChanged(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(IDsearchControl.Text, out id))
            {

                dt = PC.getproductionCycle(id);
                dataGridView.DataSource = dt;

            }
            else if (IDsearchControl.Text != null)
            {
                searchWord = IDsearchControl.Text;
                dt = PC.getproductionCycle(searchWord);
                dataGridView.DataSource = dt;

            }
            else
            {
                dt = PC.getproductionCycle();
                dataGridView.DataSource = dt;

            }
            if (dt.Rows.Count <= 0)
                resultGroupBox.Enabled = false;
            else
                resultGroupBox.Enabled = true;

        }

        private void dateCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (dateCheckBox.CheckState == CheckState.Checked)
            {
                dateSearchGroupBox.Visible = true;
                IDsearchControl.Enabled = false;
            }
            else
            {
                dateSearchGroupBox.Visible = false;
                IDsearchControl.Enabled = true;
            }



        }

        private void delete_Click(object sender, EventArgs e)
        {
            int PCid = Convert.ToInt32(this.dataGridView.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("حذف الدورة الانتاجية سيؤدي الى نقص الكمية المتوفرة من المنتجات بالاضافة لزيادة كمية المواد الخام المتوفرة ,هل تريد المواصلة في حذف الدورة الانتاجية رقم (" + PCid + ") ؟", "تحذير ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string pName = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
                int quantity = Convert.ToInt32(this.dataGridView.CurrentRow.Cells[2].Value);
                PC.delete(PCid, pName, quantity);
                MessageBox.Show("تم حذف المنتج بنجاح ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt = PC.getproductionCycle();
                dataGridView.DataSource = dt;
                if (dt.Rows.Count <= 0)
                    resultGroupBox.Enabled = false;
            }


        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = PC.searchByDateReng(startDate.Value, endDate.Value, IDsearchControl.Text);
            endDate.Enabled = true;

        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = PC.searchByDateReng(startDate.Value, endDate.Value, IDsearchControl.Text);
        }

        private void New_Click_1(object sender, EventArgs e)
        {
            newPC add = new newPC();
            add.ShowDialog();
        }
    }
}