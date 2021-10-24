using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Graduation.PL
{
    public partial class FRM_CUSTOMER : DevExpress.XtraEditors.XtraForm
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        int ID, Position;
        public FRM_CUSTOMER()
        {
            InitializeComponent();
            this.gridControl1.DataSource = cust.GET_ALL_CUSTOMERS();
            gridView1.Columns[6].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            //txtName.Clear();
            //txtCardId.Clear();
            txtAddress.Clear();
            //txtTel.Clear();
            //txtType.Clear();
            btnAdd.Enabled = true;
            //txtId.Clear();
            btnNew.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {

                byte[] picture;
                if (pbox == null)
                {
                    picture = new byte[0];
                    cust.ADD_CUSTOMER(txtName.Text, txtCardId.Text,
                                       txtAddress.Text, txtTel.Text, txtType.Text, picture, "without_image");
                    MessageBox.Show("تمت الإضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.gridControl1.DataSource = cust.GET_ALL_CUSTOMERS();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    picture = ms.ToArray();

                    cust.ADD_CUSTOMER(txtName.Text, txtCardId.Text,
                        txtAddress.Text, txtTel.Text, txtType.Text, picture, "with_image");
                    MessageBox.Show("تمت الإضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.gridControl1.DataSource = cust.GET_ALL_CUSTOMERS();
                }

            }
            catch
            {
                return;
            }
            finally
            {
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
            }

        }





        private void pbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " ملفات الصور |*.JPG; *.PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtName.Focus();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCardId.Focus();
            }
        }

        private void txtCardId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTel.Focus();
            }
        }

        private void txtTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtType.Focus();
            }
        }

        private void dgList_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    pbox.Image = null;
            //    ID = Convert.ToInt32(gridControl1.CurrentRow.Cells[0].Value);
            //    txtId.Text = dgList.CurrentRow.Cells[0].Value.ToString();
            //    this.txtName.Text = gridControl1.CurrentRow.Cells[1].Value.ToString();
            //    this.txtCardId.Text = gridControl1.CurrentRow.Cells[2].Value.ToString();
            //    this.txtAddress.Text = gridControl1.CurrentRow.Cells[3].Value.ToString();
            //    this.txtTel.Text = gridControl1.CurrentRow.Cells[4].Value.ToString();
            //    this.txtType.Text = gridControl1.CurrentRow.Cells[5].Value.ToString();
            //    byte[] picture = (byte[])gridControl1.CurrentRow.Cells[6].Value;
            //    MemoryStream ms = new MemoryStream(picture);
            //    pbox.Image = Image.FromStream(ms);
            //}
            //catch
            //{
            //    return;
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID == 0)
                {
                    MessageBox.Show("العميل المراد تعديله  غير موجود");
                    return;
                }
                byte[] picture;
                if (pbox == null)
                {

                    picture = new byte[0];
                    cust.EDIT_CUSTOMER(txtName.Text, txtCardId.Text,
                                       txtAddress.Text, txtTel.Text, txtType.Text, picture, "without_image", ID);
                    MessageBox.Show("تم التعديل بنجاح", "EDIT PROCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.gridControl1.DataSource = cust.GET_ALL_CUSTOMERS();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    picture = ms.ToArray();

                    cust.EDIT_CUSTOMER(txtName.Text, txtCardId.Text,
                        txtAddress.Text, txtTel.Text, txtType.Text, picture, "with_image", ID);
                    MessageBox.Show("تمت التعديل بنجاح", "EDIT PROCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.gridControl1.DataSource = cust.GET_ALL_CUSTOMERS();
                }
            }
            catch
            {
                return;
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("العميل المراد حذفه غير موجود");
                return;
            }
            if (MessageBox.Show("هل تريد فعلاً حذف هذا العميل", "Delete Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cust.DELETE_CUSTOMER(ID);
                MessageBox.Show("تمت الحذف بنجاح", "Delete PROCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gridControl1.DataSource = cust.GET_ALL_CUSTOMERS();
                //txtName.Clear();
                //   txtCardId.Clear();
                txtAddress.Clear();
                // txtTel.Clear();
                //  txtType.Clear();
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = cust.Search_Customer(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.Focus();
            }
        }


        void Navigate(int Index)
        {
            try
            {
                pbox.Image = null;
                DataTable Dt = cust.GET_ALL_CUSTOMERS();

                txtName.Text = Dt.Rows[Index][1].ToString();
                txtCardId.Text = Dt.Rows[Index][2].ToString();
                txtAddress.Text = Dt.Rows[Index][3].ToString();
                txtTel.Text = Dt.Rows[Index][4].ToString();
                txtType.Text = Dt.Rows[Index][5].ToString();
                byte[] picture = (byte[])Dt.Rows[Index][6];
                MemoryStream ms = new MemoryStream(picture);
                pbox.Image = Image.FromStream(ms);

            }
            catch
            {
                return;
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Navigate(0);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            Position = cust.GET_ALL_CUSTOMERS().Rows.Count - 1;
            Navigate(Position);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (Position == 0)
            {
                MessageBox.Show("هذا اول عنصر");
                return;
            }
            Position -= 1;
            Navigate(Position);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (Position == cust.GET_ALL_CUSTOMERS().Rows.Count - 1)
            {
                MessageBox.Show("هذا آخر عنصر");
                return;
            }

            Position += 1;
            Navigate(Position);

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

    }
}