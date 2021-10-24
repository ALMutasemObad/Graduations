using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Graduation.PL
{
    public partial class newBond : DevExpress.XtraEditors.XtraForm
    {
        string formName = "newBond";
        BL.Bonds bnd = new BL.Bonds();
        string tableName = "GUARANTEES";
        string bandType;
        int bondID;
        int customer_Id;
        string valdity;
        DateTime tsdedDate;
        DateTime bondDate;
        int valueBond;
        string bondDesc;


        public newBond()
        {
           

            InitializeComponent();
        }

        private void oprtionsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void newBond_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CUSTOMERS' table. You can move, or remove it, as needed.
            this.cUSTOMERSTableAdapter.Fill(this.dataSet1.CUSTOMERS);

            bondID = bnd.qGetNextId(tableName);
            bondIDtextBox.Text = bondID.ToString();
            dateTextBox.Text = DateTime.Now.ToString();
            bondDate = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now;
            

        }

        private void valueBondtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
         
        }

        private void custmerNLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

            customer_Id = int.Parse(custmerNLookUpEdit.EditValue.ToString()) ;

            detilsGroupBox.Enabled = true;

        }

        private void bandTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             bandType = bandTypeComboBox.SelectedText;
            dateGroupBox.Enabled = true; 

        }

        private void valditycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            valdity = valditycomboBox.SelectedText;
            oprtionsGroupBox.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             tsdedDate = dateTimePicker1.Value;
            valditycomboBox.Enabled = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
           // addCustomer frm = new addCustomer();
            //frm.privusForm = formName;
          //  frm.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            valdity = "سنة";
            bandType = "سلاح";
            valueBond = int.Parse(valueBondtextBox.Text);
            bondDesc = descTextBox.Text;
            bnd.addTheBond(bondID, customer_Id, bandType, valueBond, bondDate, tsdedDate, valdity);
            MessageBox.Show("تم حفظ الرهن بنجاح ");
            Close();

        }
    }
}