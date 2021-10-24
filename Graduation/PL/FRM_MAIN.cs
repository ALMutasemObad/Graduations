using DevExpress.XtraBars;
using Microsoft.Win32;
using System;
using System.Windows.Forms;


namespace Graduation.PL
{
    public partial class FRM_MAIN : DevExpress.XtraBars.Ribbon.RibbonForm
    {


        public FRM_MAIN()
        {
            InitializeComponent();

        }

        public void ShowFormsCount()
        {
            barFormCount.Caption = " الشاشات المفتوحة: " + " " + (Application.OpenForms.Count - 2).ToString();
        }


        private void OpenForms(Form form)
        {


            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "frmStart" || frm.Name == "FRM_MAIN") continue;
                if (form.Name == frm.Name)
                {
                    frm.Activate();
                    return;
                }
            }

            // form.MdiParent = this;
            form.WindowState = v.FormCurrentState;
            form.FormClosed += delegate { ShowFormsCount(); };
            form.Show();
            ShowFormsCount();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }



        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new FRM_CUSTOMER());
            //FRM_CUSTOMER frm = new FRM_CUSTOMER();
            //// frm.MdiParent = this;
            //frm.Show();

        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Close();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new FRM_CUSTOMER_AC());
            //FRM_CUSTOMER_AC frm = new FRM_CUSTOMER_AC();
            //frm.Show();

        }





        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            RegistryKey SkinName = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\WINREGISTRY");
            if (SkinName != null)
            {
                //DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = SkinName.GetValue("SkinName").ToString();
            }

            this.barStaticItem1.Caption = " أسم المستخدم: " + " " + v.UserName;
            this.barStaticItem2.Caption = "التاريخ: " + " " + DateTime.Now.Date.ToShortDateString();

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            this.barStaticItem4.Caption = " الوقت الحالــي: " + " " + DateTime.Now.ToShortTimeString();
        }

        private void FRM_MAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryKey SkinName = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\WINREGISTRY");
            SkinName.SetValue("SkinName", DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName.ToString());
            SkinName.Close();
            Application.Exit();

        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new FRM_Orders());
            //FRM_Orders frm = new FRM_Orders();
            //frm.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new FRM_SaProRe());
            //FRM_SaProRe frm = new FRM_SaProRe();
            //frm.Show();

        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new FRM_SaleReport());
            //FRM_SaleReport frm = new FRM_SaleReport();
            //frm.Show();
        }



        private void brbtnOpenForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new FRM_OpenForm());
            // FRM_OpenForm frm = new FRM_OpenForm();
            //// frm.MdiParent = this;
            // frm.Show(); 

        }

        private void brBtnAdddProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new frmItem());
            //FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            //frm.Show();
            //frm.MdiParent = this;

        }

        private void brBtnMangeProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new frmItemShow());
            // FRM_PRODUCTS frm = new FRM_PRODUCTS();
            ////frm.MdiParent = this;
            // frm.Show();
        }

        private void brBtnMangeCate_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new FRM_Catogreis());
            //OpenForms(new dataGridView());
            //dataGridView frm = new dataGridView();
            //frm.Show();
        }

        private void brBtnOpenMaximize_ItemClick(object sender, ItemClickEventArgs e)
        {
            v.FormCurrentState = FormWindowState.Maximized;
        }

        private void brBtnOpenMediam_ItemClick(object sender, ItemClickEventArgs e)
        {
            v.FormCurrentState = FormWindowState.Normal;
        }

        private void brBtnMninmize_ItemClick(object sender, ItemClickEventArgs e)
        {
            v.FormCurrentState = FormWindowState.Minimized;

        }

        private void titItmClose_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Application.Exit();
        }

        private void brBtnEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new FRM_Employee());
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new FRM_USERS());
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new frmUnit());
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new frmStore());
        }

        private void barButtonItem40_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new ProdCclMngmnt());
        }

        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new newPC());
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new frmProgramSetting());
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new frmCustomerPayedValue());
        }

        private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForms(new FRM_CUSTOMER());
        }






    }
}