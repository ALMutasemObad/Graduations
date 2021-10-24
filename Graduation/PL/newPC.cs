using System;
using System.Data;
using System.Windows.Forms;
namespace Graduation.PL
{
    public partial class newPC : DevExpress.XtraEditors.XtraForm
    {
        DataGridView DGV = new DataGridView();
        BL.prodCycle PC = new BL.prodCycle();
        DataTable dt = new DataTable();
        string tableName = "productioncycle";
        int Prod_Id;
        DialogResult dialogResult;
        string baracode;
        public newPC()
        {
            InitializeComponent();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            string idPC = idTextBox.Text;
            Prod_Id = Convert.ToInt32(lookUpEdit1.EditValue);

            dt = PC.getProductComPonents(Prod_Id, quntitytextBox.Text);
            gridControl1.DataSource = dt;
            textBox3.Text = totalCost(dt).ToString();
            dialogResult = DialogResult.None;
            RawMtGroupBox.Enabled = true;
            groupControl1.Enabled = true;
            saveButton.Enabled = true;
            int q = int.Parse(quntitytextBox.Text);
            q += 10;
            quntitytextBox.Text = q.ToString();
            baracode = "0" + idPC + "0" + Prod_Id;
            baraCodetextBox.Text = baracode;
        }

        private void newPC_Load(object sender, EventArgs e)
        {
            idTextBox.Text = "100";
            // TODO: This line of code loads data into the 'dataSet2.PRODUCT' table. You can move, or remove it, as needed.
            idTextBox.Text = PC.qGetNextId(tableName).ToString();
            dateTextBox.Text = DateTime.Now.ToString();
            DataTable dt;
            dt = PC.qGetTable("product").Columns[0].Table;
            dt = PC.qGetTable("product").Columns[1].Table;
            lookUpEdit1.Properties.DataSource = dt;
            lookUpEdit1.Properties.DisplayMember = "item_name";
            lookUpEdit1.Properties.ValueMember = "item_number";

            lookUpEdit1.Properties.PopulateColumns();
            lookUpEdit1.Properties.Columns[0].Visible = false;
            lookUpEdit1.Properties.Columns[2].Visible = false;
            lookUpEdit1.Properties.Columns[3].Visible = false;
            lookUpEdit1.Properties.Columns[4].Visible = false;
            lookUpEdit1.Properties.Columns[5].Visible = false;
            lookUpEdit1.Properties.Columns[6].Visible = false;
            lookUpEdit1.Properties.Columns[7].Visible = false;
            lookUpEdit1.Properties.Columns[8].Visible = false;
            lookUpEdit1.Properties.Columns[9].Visible = false;
            lookUpEdit1.Properties.Columns[10].Visible = false;
            //lookUpEdit1.Properties.Columns[11].Visible = false;
            //lookUpEdit1.Properties.Columns[12].Visible = false;
            //lookUpEdit1.Properties.Columns[13].Visible = false;
            //lookUpEdit1.Properties.Columns[14].Visible = false;
            RawMtGroupBox.Enabled = false;
            groupControl1.Enabled = false;
            saveButton.Enabled = false;

        }



        private void incresButton_Click(object sender, EventArgs e)
        {
            int Nquntity = int.Parse(quntitytextBox.Text) + 10;
            quntitytextBox.Text = Nquntity.ToString();

        }

        private void dicresButton_Click(object sender, EventArgs e)
        {
            int Nquntity;
            if (Convert.ToInt32(quntitytextBox.Text) <= 10)
                Nquntity = 1;
            else
                Nquntity = int.Parse(quntitytextBox.Text) - 10;
            quntitytextBox.Text = Nquntity.ToString();
        }




        private int totalCost(DataTable dt)
        {
            int x = 0;
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {


                x += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

            }
            return x;
        }
        private int check(DataTable dt)
        {


            dataGridView1.DataSource = dt;
            int result = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int x = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                int y = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                if (x > y)
                {
                    result += 1;
                }
            }
            return result;

        }
        private void control(int result)
        {
            if (result > 0)
            {
                dialogResult = MessageBox.Show("لا يوجد كميات كافية في المخزن لـ(" + result + ")من المواد  المطلوبة هل تريد انشاء تقرير بالمواد المطلوب توفيرها ؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    saveButton.Enabled = false;
                    RawMtGroupBox.Enabled = true;
                    groupControl1.Enabled = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    int z = Convert.ToInt32(quntitytextBox.Text);
                    dataGridView1.DataSource = PC.getProductComPonents(Prod_Id, quntitytextBox.Text);
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        int q = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                        int y = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                        z = y * 1000 / q;
                        if (z < 1)
                            this.Close();
                    }
                    quntitytextBox.Text = z.ToString();
                }
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //  int z = Convert.ToInt32(quntitytextBox.Text);
            dataGridView1.DataSource = dt;
            int result = check(dt);
            if (result > 0)
            {
                MessageBox.Show(" لا يمكنك حفظ الدورة الانتاجية فهناك (" + result + ") من المواد المطلوبة غير متوفرة في المخزن يجب توفير المواد الخام اولا ", " خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == 0)
            {
                int idPC = Convert.ToInt32(idTextBox.Text);
                int quntity = Convert.ToInt32(quntitytextBox.Text);
                DateTime date = DateTime.Today;
                string totalcost = textBox3.Text;
                PC.insert(idPC, Prod_Id, quntity, date, totalcost);
                for (int I = 0; I < dataGridView1.Rows.Count; I++)
                {
                    int qRM = Convert.ToInt32(dataGridView1.Rows[I].Cells[4].Value);
                    int qused = Convert.ToInt32(dataGridView1.Rows[I].Cells[2].Value);
                    int idRM = Convert.ToInt32(dataGridView1.Rows[I].Cells[5].Value);
                    int newQ = qRM - qused;
                    PC.Update(newQ, idRM);
                }
                MessageBox.Show("تم حفظ الدورة الانتاجية  بنجاح ");
                Close();
            }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void quntitytextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }



        private void quntitytextBox_EditValueChanged_1(object sender, EventArgs e)
        {
            if (quntitytextBox.Text == "")
                quntitytextBox.Text = "1";
            dt = PC.getProductComPonents(Prod_Id, quntitytextBox.Text);
            gridControl1.DataSource = dt;
            if (dialogResult != DialogResult.Yes)
                control(check(dt));
            textBox3.Text = totalCost(dt).ToString();

        }

        private void gridControl1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}