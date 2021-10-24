namespace Graduation.PL
{
    partial class FRM_CUSTOMER_AC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CUSTOMER_AC));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lkuSearch = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.radoBtnSpecifiedCustomer = new System.Windows.Forms.RadioButton();
            this.radoBtnAllCustomer = new System.Windows.Forms.RadioButton();
            this.dgvDelayCustomers = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTotalRemainedValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnPayment = new DevExpress.XtraEditors.SimpleButton();
            this.radoBtnPaymentPart = new System.Windows.Forms.RadioButton();
            this.radoBtnPaymentAll = new System.Windows.Forms.RadioButton();
            this.txtPayment = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelayCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalRemainedValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayment.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lkuSearch);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.radoBtnSpecifiedCustomer);
            this.panelControl1.Controls.Add(this.radoBtnAllCustomer);
            this.panelControl1.Location = new System.Drawing.Point(2, 38);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(799, 46);
            this.panelControl1.TabIndex = 0;
            // 
            // lkuSearch
            // 
            this.lkuSearch.EditValue = "";
            this.lkuSearch.Location = new System.Drawing.Point(285, 16);
            this.lkuSearch.Name = "lkuSearch";
            this.lkuSearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lkuSearch.Properties.Appearance.Options.UseFont = true;
            this.lkuSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuSearch.Properties.ShowHeader = false;
            this.lkuSearch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkuSearch.Size = new System.Drawing.Size(214, 20);
            this.lkuSearch.TabIndex = 5;
            this.lkuSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lkuSearch_KeyDown);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton2.Location = new System.Drawing.Point(60, 7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(150, 34);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "طباعة تقرير مفصل";
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSearch.Location = new System.Drawing.Point(216, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radoBtnSpecifiedCustomer
            // 
            this.radoBtnSpecifiedCustomer.AutoSize = true;
            this.radoBtnSpecifiedCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radoBtnSpecifiedCustomer.Location = new System.Drawing.Point(524, 15);
            this.radoBtnSpecifiedCustomer.Name = "radoBtnSpecifiedCustomer";
            this.radoBtnSpecifiedCustomer.Size = new System.Drawing.Size(96, 20);
            this.radoBtnSpecifiedCustomer.TabIndex = 1;
            this.radoBtnSpecifiedCustomer.TabStop = true;
            this.radoBtnSpecifiedCustomer.Text = "عميل محدد";
            this.radoBtnSpecifiedCustomer.UseVisualStyleBackColor = true;
            this.radoBtnSpecifiedCustomer.CheckedChanged += new System.EventHandler(this.radoBtnSpecifiedCustomer_CheckedChanged);
            // 
            // radoBtnAllCustomer
            // 
            this.radoBtnAllCustomer.AutoSize = true;
            this.radoBtnAllCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.radoBtnAllCustomer.Location = new System.Drawing.Point(671, 15);
            this.radoBtnAllCustomer.Name = "radoBtnAllCustomer";
            this.radoBtnAllCustomer.Size = new System.Drawing.Size(88, 20);
            this.radoBtnAllCustomer.TabIndex = 0;
            this.radoBtnAllCustomer.TabStop = true;
            this.radoBtnAllCustomer.Text = "كل العملاء";
            this.radoBtnAllCustomer.UseVisualStyleBackColor = true;
            this.radoBtnAllCustomer.CheckedChanged += new System.EventHandler(this.radoBtnAllCustomer_CheckedChanged);
            // 
            // dgvDelayCustomers
            // 
            this.dgvDelayCustomers.AllowUserToResizeColumns = false;
            this.dgvDelayCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDelayCustomers.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvDelayCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelayCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDelayCustomers.Location = new System.Drawing.Point(2, 86);
            this.dgvDelayCustomers.Name = "dgvDelayCustomers";
            this.dgvDelayCustomers.RowHeadersWidth = 30;
            this.dgvDelayCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDelayCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDelayCustomers.Size = new System.Drawing.Size(799, 247);
            this.dgvDelayCustomers.TabIndex = 62;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.txtTotalRemainedValue);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnPayment);
            this.groupControl1.Controls.Add(this.radoBtnPaymentPart);
            this.groupControl1.Controls.Add(this.radoBtnPaymentAll);
            this.groupControl1.Controls.Add(this.txtPayment);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(2, 336);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(799, 100);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "طريقة الدفع";
            // 
            // txtTotalRemainedValue
            // 
            this.txtTotalRemainedValue.EnterMoveNextControl = true;
            this.txtTotalRemainedValue.Location = new System.Drawing.Point(5, 43);
            this.txtTotalRemainedValue.Name = "txtTotalRemainedValue";
            this.txtTotalRemainedValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtTotalRemainedValue.Properties.Appearance.Options.UseFont = true;
            this.txtTotalRemainedValue.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalRemainedValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTotalRemainedValue.Properties.ReadOnly = true;
            this.txtTotalRemainedValue.Size = new System.Drawing.Size(165, 20);
            this.txtTotalRemainedValue.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(176, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 19);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "أجمالي المبالغ المتبقية:";
            // 
            // btnPayment
            // 
            this.btnPayment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.ImageOptions.Image")));
            this.btnPayment.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnPayment.Location = new System.Drawing.Point(305, 34);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(124, 35);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "تسديد المبلغ المحدد";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // radoBtnPaymentPart
            // 
            this.radoBtnPaymentPart.AutoSize = true;
            this.radoBtnPaymentPart.Font = new System.Drawing.Font("Tahoma", 8F);
            this.radoBtnPaymentPart.Location = new System.Drawing.Point(578, 46);
            this.radoBtnPaymentPart.Name = "radoBtnPaymentPart";
            this.radoBtnPaymentPart.Size = new System.Drawing.Size(93, 17);
            this.radoBtnPaymentPart.TabIndex = 3;
            this.radoBtnPaymentPart.TabStop = true;
            this.radoBtnPaymentPart.Text = "تسديد جزء منه";
            this.radoBtnPaymentPart.UseVisualStyleBackColor = true;
            this.radoBtnPaymentPart.CheckedChanged += new System.EventHandler(this.radoBtnPaymentPart_CheckedChanged);
            // 
            // radoBtnPaymentAll
            // 
            this.radoBtnPaymentAll.AutoSize = true;
            this.radoBtnPaymentAll.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radoBtnPaymentAll.Location = new System.Drawing.Point(682, 46);
            this.radoBtnPaymentAll.Name = "radoBtnPaymentAll";
            this.radoBtnPaymentAll.Size = new System.Drawing.Size(110, 17);
            this.radoBtnPaymentAll.TabIndex = 2;
            this.radoBtnPaymentAll.TabStop = true;
            this.radoBtnPaymentAll.Text = "تسديد المبلغ كامل";
            this.radoBtnPaymentAll.UseVisualStyleBackColor = true;
            this.radoBtnPaymentAll.CheckedChanged += new System.EventHandler(this.radoBtnPaymentAll_CheckedChanged);
            // 
            // txtPayment
            // 
            this.txtPayment.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPayment.Location = new System.Drawing.Point(431, 42);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPayment.Properties.Appearance.Options.UseFont = true;
            this.txtPayment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPayment.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtPayment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtPayment.Size = new System.Drawing.Size(141, 22);
            this.txtPayment.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(302, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(200, 16);
            this.labelControl1.TabIndex = 63;
            this.labelControl1.Text = "المبالغ المتبقية على العملاء آجل ";
            // 
            // FRM_CUSTOMER_AC
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 442);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dgvDelayCustomers);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CUSTOMER_AC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابات العملاء آجل";
            this.Load += new System.EventHandler(this.FRM_CUSTOMER_AC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelayCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalRemainedValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayment.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.RadioButton radoBtnSpecifiedCustomer;
        private System.Windows.Forms.RadioButton radoBtnAllCustomer;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnPayment;
        private System.Windows.Forms.RadioButton radoBtnPaymentPart;
        private System.Windows.Forms.RadioButton radoBtnPaymentAll;
        private DevExpress.XtraEditors.SpinEdit txtPayment;
        public System.Windows.Forms.DataGridView dgvDelayCustomers;
        private DevExpress.XtraEditors.LookUpEdit lkuSearch;
        private DevExpress.XtraEditors.TextEdit txtTotalRemainedValue;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}