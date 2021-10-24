using System;

namespace Graduation.PL
{
    public partial class Product_List : DevExpress.XtraEditors.XtraForm
    {
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        public Product_List()
        {
            InitializeComponent();
            dgvP.DataSource = prd.GET_ALL_PRODUCTS();
        }



        private void dgvP_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}