using System;
using System.Windows.Forms;

namespace Graduation.PL
{
    public partial class FRM_PRODUCTS : DevExpress.XtraEditors.XtraForm
    {
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        public FRM_PRODUCTS()
        {
            InitializeComponent();
            this.gridControl1.DataSource = prd.GET_ALL_PRODUCTS();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void FRM_PRODUCTS_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'graduation_DBDataSet4.PRODUCTS' table. You can move, or remove it, as needed.
        //    this.pRODUCTSTableAdapter.Fill(this.graduation_DBDataSet4.PRODUCTS);

        //}
    }
}