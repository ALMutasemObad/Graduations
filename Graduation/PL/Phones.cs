using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class Phones : DevExpress.XtraEditors.XtraUserControl
    {
        public Phones()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            txtPhone.Text = "";
            btnAddPhone.Enabled = true;
            btnEditPhone.Enabled = false;
            btnDeletePhone.Enabled = false;
            txtPhone.Select();
        }

        private DataTable tblPhones = new DataTable();

        private string FilterPhone(string phone)
        {
            string PhoneAfterFilter = "";

            foreach (char c in phone)
            {
                if (char.IsDigit(c))
                    PhoneAfterFilter += c;
            }
            return PhoneAfterFilter;
        }

        private void PhonesToGrid()
        {
            tblPhones = tblPhones.DefaultView.ToTable(true, "phone");
            dgvPhones.DataSource = tblPhones;
        }

        private void AddPhone(string phone)
        {
            if (tblPhones.Columns.Count < 1) tblPhones.Columns.Add("phone");

            tblPhones.Rows.Add(FilterPhone(phone));
            PhonesToGrid();
        }


        private DataRow FindRow(string phone)
        {
            if (tblPhones.Constraints.Count < 1)
                tblPhones.Constraints.Add("phone_pk", tblPhones.Columns[0], true);
            return tblPhones.Rows.Find(phone);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text.Trim() != "")
            {
                AddPhone(txtPhone.Text);
                ClearData();
            }

        }

        private void Phones_Load(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnAddPhone.Enabled)
            {
                btnAddPhone.PerformClick();
            }
        }

        private void dgvPhones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhones.CurrentRow != null)
            {
                txtPhone.Text = dgvPhones.CurrentRow.Cells[0].Value.ToString();
                btnAddPhone.Enabled = false;
                btnEditPhone.Enabled = true;
                btnDeletePhone.Enabled = true;

            }
        }

        private void btnEditPhone_Click(object sender, EventArgs e)
        {
            if (dgvPhones.CurrentRow != null)
            {
                DataRow RowForEdit = FindRow(dgvPhones.CurrentRow.Cells[0].Value.ToString());
                if (RowForEdit != null)
                {
                    tblPhones.Constraints.Clear();
                    RowForEdit[0] = FilterPhone(txtPhone.Text);
                }
                PhonesToGrid();
                ClearData();
            }
        }

        private void btnDeletePhone_Click(object sender, EventArgs e)
        {
            if (dgvPhones.CurrentRow != null)
            {
                DataRow RowForDelete = FindRow(dgvPhones.CurrentRow.Cells[0].Value.ToString());
                if (RowForDelete != null)
                {
                    RowForDelete.Delete();
                }
                PhonesToGrid();
                ClearData();
            }

        }

        //هذه خمسة خيارات لكي يرجع التلفونات إما عبر الجدول أو عن طريق صفوف او عن مصفوفةكائن واحد اخر يرجعها مصفوفة استرنج والاخير يرجعها كلها

        public DataTable GetPhonesAsDataTable()
        {
            return tblPhones;
        }
        public DataRow[] GetPhonesAsDataRowArray()
        {
            return tblPhones.Select();
        }
        public object[] GetPhonesAsObjectArray()
        {
            object[] o = new object[tblPhones.Rows.Count];
            DataRow[] rows = GetPhonesAsDataRowArray();
            for (int i = 0; i < tblPhones.Rows.Count; i += 1)
            {
                o[i] = rows[i][0];
            }
            return o;
        }

        public string[] GetPhonesAsStringArray()
        {
            string[] o = new string[tblPhones.Rows.Count];
            DataRow[] rows = GetPhonesAsDataRowArray();
            for (int i = 0; i < tblPhones.Rows.Count; i += 1)
            {
                o[i] = rows[i][0].ToString();
            }
            return o;
        }

        public string GetPhonesAsString()
        {
            string allPhones = "";
            string[] str = GetPhonesAsStringArray();
            for (int i = 0; i < str.Count(); i += 1)
            {
                allPhones += str[i] + ((i < str.Count() - 1 ? " , " : ""));
            }
            return allPhones;
        }

        public int Count()
        {
            return tblPhones.Rows.Count;
        }
        private void Phones_Resize(object sender, EventArgs e)
        {
            //if (this.Width < 345) this.Width = 345;

            // ///label And text
            // txtPhone.Left = 10;
            // txtPhone.Width = this.Width - lblPhones.Width - 20;
            // lblPhones.Left = txtPhone.Width + 10;

            // //////Buttons
            // int SpaceButton =5;
            // int btnWidth = (this.Width / 4) - (SpaceButton * 2);
            // btnNew.Width = btnWidth;
            // btnAddPhone.Width = btnWidth;
            // btnEditPhone.Width = btnWidth;
            // btnDeletePhone.Width = btnWidth;

            // btnDeletePhone.Left = SpaceButton;
            // btnEditPhone.Left = btnDeletePhone.Left + btnDeletePhone.Width + SpaceButton;
            // btnAddPhone.Left = btnEditPhone.Left + btnEditPhone.Width + SpaceButton;
            // btnNew.Left = btnAddPhone.Left + btnAddPhone.Width + SpaceButton;

            // ///grid
            // dgvPhones.Left = 10;
            // dgvPhones.Width = this.Width - 20;

        }


        /////////////
    }
}
