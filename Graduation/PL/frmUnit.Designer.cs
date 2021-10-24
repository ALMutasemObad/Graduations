namespace Graduation.PL
{
    partial class frmUnit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnit));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtUnitN = new DevExpress.XtraEditors.TextEdit();
            this.btnNewUnit = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddUnit = new DevExpress.XtraEditors.SimpleButton();
            this.txtUnitName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnitDetail = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitDetail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.groupControl1.Controls.Add(this.txtUnitN);
            this.groupControl1.Controls.Add(this.btnNewUnit);
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnAddUnit);
            this.groupControl1.Controls.Add(this.txtUnitName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtUnitDetail);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(556, 220);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "الوحـــدات";
            // 
            // txtUnitN
            // 
            this.txtUnitN.EnterMoveNextControl = true;
            this.txtUnitN.Location = new System.Drawing.Point(163, 66);
            this.txtUnitN.Name = "txtUnitN";
            this.txtUnitN.Properties.ReadOnly = true;
            this.txtUnitN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUnitN.Size = new System.Drawing.Size(271, 20);
            this.txtUnitN.TabIndex = 0;
            // 
            // btnNewUnit
            // 
            this.btnNewUnit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewUnit.ImageOptions.Image")));
            this.btnNewUnit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnNewUnit.Location = new System.Drawing.Point(18, 121);
            this.btnNewUnit.Name = "btnNewUnit";
            this.btnNewUnit.Size = new System.Drawing.Size(113, 37);
            this.btnNewUnit.TabIndex = 4;
            this.btnNewUnit.Text = "جــــديد";
            this.btnNewUnit.Click += new System.EventHandler(this.btnNewUnit_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnClose.Location = new System.Drawing.Point(18, 170);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUnit.ImageOptions.Image")));
            this.btnAddUnit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAddUnit.Location = new System.Drawing.Point(18, 69);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(113, 37);
            this.btnAddUnit.TabIndex = 3;
            this.btnAddUnit.Text = "إضافة وحدة";
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // txtUnitName
            // 
            this.txtUnitName.EnterMoveNextControl = true;
            this.txtUnitName.Location = new System.Drawing.Point(163, 99);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUnitName.Size = new System.Drawing.Size(271, 20);
            this.txtUnitName.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial Black", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(436, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 23);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "تفاصيل الوحدة:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Black", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(457, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 23);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "أسم الوحدة:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Black", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(458, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "رقم الوحدة:";
            // 
            // txtUnitDetail
            // 
            this.txtUnitDetail.EnterMoveNextControl = true;
            this.txtUnitDetail.Location = new System.Drawing.Point(163, 132);
            this.txtUnitDetail.Name = "txtUnitDetail";
            this.txtUnitDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUnitDetail.Size = new System.Drawing.Size(271, 69);
            this.txtUnitDetail.TabIndex = 2;
            // 
            // frmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 220);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmUnit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة تعريف الوحدات";
            this.Load += new System.EventHandler(this.frmUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitDetail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnNewUnit;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnAddUnit;
        private DevExpress.XtraEditors.TextEdit txtUnitName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUnitN;
        private DevExpress.XtraEditors.MemoEdit txtUnitDetail;
    }
}