namespace Graduation.PL
{
    partial class FRM_OpenForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_OpenForm));
            this.lbxTextForm = new DevExpress.XtraEditors.ListBoxControl();
            this.lbxNameForm = new DevExpress.XtraEditors.ListBoxControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lbCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnRefreshOpenForms = new DevExpress.XtraEditors.SimpleButton();
            this.cbxAutoRefresh = new DevExpress.XtraEditors.CheckEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lbxTextForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbxNameForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAutoRefresh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxTextForm
            // 
            this.lbxTextForm.Location = new System.Drawing.Point(12, 43);
            this.lbxTextForm.Name = "lbxTextForm";
            this.lbxTextForm.Size = new System.Drawing.Size(607, 221);
            this.lbxTextForm.TabIndex = 0;
            this.lbxTextForm.DoubleClick += new System.EventHandler(this.lbxTextForm_DoubleClick);
            // 
            // lbxNameForm
            // 
            this.lbxNameForm.Location = new System.Drawing.Point(625, 43);
            this.lbxNameForm.Name = "lbxNameForm";
            this.lbxNameForm.Size = new System.Drawing.Size(182, 221);
            this.lbxNameForm.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(461, 270);
            this.btnClose.LookAndFeel.SkinName = "Seven Classic";
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "أغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbCount
            // 
            this.lbCount.Location = new System.Drawing.Point(267, 24);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(63, 13);
            this.lbCount.TabIndex = 3;
            this.lbCount.Text = "labelControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(221, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "اضغط Double Click لعرض النافذة المفتوحة";
            // 
            // btnRefreshOpenForms
            // 
            this.btnRefreshOpenForms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshOpenForms.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshOpenForms.ImageOptions.Image")));
            this.btnRefreshOpenForms.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnRefreshOpenForms.Location = new System.Drawing.Point(298, 270);
            this.btnRefreshOpenForms.LookAndFeel.SkinName = "Seven Classic";
            this.btnRefreshOpenForms.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnRefreshOpenForms.Name = "btnRefreshOpenForms";
            this.btnRefreshOpenForms.Size = new System.Drawing.Size(139, 30);
            this.btnRefreshOpenForms.TabIndex = 5;
            this.btnRefreshOpenForms.Text = "تحديث الشاشات";
            this.btnRefreshOpenForms.Click += new System.EventHandler(this.btnRefreshOpenForms_Click);
            // 
            // cbxAutoRefresh
            // 
            this.cbxAutoRefresh.EditValue = true;
            this.cbxAutoRefresh.Location = new System.Drawing.Point(405, 21);
            this.cbxAutoRefresh.Name = "cbxAutoRefresh";
            this.cbxAutoRefresh.Properties.Caption = "تحديث تلقائي";
            this.cbxAutoRefresh.Size = new System.Drawing.Size(116, 19);
            this.cbxAutoRefresh.TabIndex = 6;
            this.cbxAutoRefresh.CheckedChanged += new System.EventHandler(this.cbxAutoRefresh_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_OpenForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 310);
            this.Controls.Add(this.cbxAutoRefresh);
            this.Controls.Add(this.btnRefreshOpenForms);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbxNameForm);
            this.Controls.Add(this.lbxTextForm);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FRM_OpenForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض الشاشات المفتوحة";
            this.Load += new System.EventHandler(this.FRM_OpenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbxTextForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbxNameForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAutoRefresh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl lbxTextForm;
        private DevExpress.XtraEditors.ListBoxControl lbxNameForm;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl lbCount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRefreshOpenForms;
        private DevExpress.XtraEditors.CheckEdit cbxAutoRefresh;
        private System.Windows.Forms.Timer timer1;
    }
}