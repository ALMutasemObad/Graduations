using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;

namespace Graduation.PL
{
    public partial class FRM_SAVE_SALE : DevExpress.XtraEditors.XtraForm
    {
        FRM_Orders frm = new FRM_Orders();
        BL.CLs_Item unit = new BL.CLs_Item();

        BL.CLS_SAILES order = new BL.CLS_SAILES();

        public FRM_SAVE_SALE()
        {
            InitializeComponent();

        }




        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (cmbItemUnit.Text.Trim() == "")
            {
                XtraMessageBox.Show("مربع الوحدة فارغ");
                cmbItemUnit.Select();
            }
            else
            {
                v.discount = txtDiscount.Text;
                v.price = txtPrice.Text;
                v.unit = cmbItemUnit.SelectedText;
                v.Qty = txtQty.Text;
                Close();
            }





            //        if (frm.txtSearch.Text!=string.Empty)
            //        {
            //            order.ADD_ORDERS(Convert.ToInt32(frm.txtOrderId.Text), Convert.ToInt32(frm.txtSearch.EditValue),Convert.ToDateTime(frm.sale_date),
            //                Convert.ToDouble(frm.txtSumTotal.Text), Convert.ToDouble(txtPrice.Text),
            //                Convert.ToDouble(txtRemainValue.Text),Convert.ToDateTime(frm.pay_date), frm.txtSaleMan.Text, "direct_cust");


            //            XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "تمت الإضافلة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            order.ADD_ORDERS(Convert.ToInt32(frm.txtOrderId.Text), Convert.ToInt32(frm.txtSearch.EditValue),Convert.ToDateTime(frm.sale_date.Value),Convert.ToDouble( frm.txtSumTotal.Text),
            //              Convert.ToDouble(txtPrice.Text),Convert.ToDouble(txtRemainValue.Text), frm.pay_date.Value, frm.txtSaleMan.Text, "not_direct_cust");

            //            XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, "تمت الإضافلة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }

        }

        private void FRM_SAVE_SALE_Load(object sender, EventArgs e)
        {
            txtDiscount.Text = v.discount;
            txtPrice.Text = v.price;
            cmbItemUnit.Text = v.unit;
            txtQty.Text = v.Qty;

            DataTable tblUnit = unit.get_unit();
            cmbItemUnit.Properties.DataSource = tblUnit;
            cmbItemUnit.Properties.ValueMember = "unit_no";
            cmbItemUnit.Properties.DisplayMember = "unit_name";

            cmbItemUnit.Properties.PopulateColumns();
            cmbItemUnit.Properties.Columns[0].Visible = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
