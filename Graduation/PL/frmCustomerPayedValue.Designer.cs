namespace Graduation.PL
{
    partial class frmCustomerPayedValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerPayedValue));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lkuSearch = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.radoBtnSpecifiedCustomer = new System.Windows.Forms.RadioButton();
            this.radoBtnAllCustomer = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvDelayCustomers = new System.Windows.Forms.DataGridView();
            this.txtTotalPayedValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelayCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPayedValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lkuSearch);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.radoBtnSpecifiedCustomer);
            this.panelControl1.Controls.Add(this.radoBtnAllCustomer);
            this.panelControl1.Location = new System.Drawing.Point(3, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelControl1.Size = new System.Drawing.Size(765, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // lkuSearch
            // 
            this.lkuSearch.EditValue = "";
            this.lkuSearch.Location = new System.Drawing.Point(217, 15);
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
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSearch.Location = new System.Drawing.Point(148, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radoBtnSpecifiedCustomer
            // 
            this.radoBtnSpecifiedCustomer.AutoSize = true;
            this.radoBtnSpecifiedCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radoBtnSpecifiedCustomer.ForeColor = System.Drawing.Color.Red;
            this.radoBtnSpecifiedCustomer.Location = new System.Drawing.Point(437, 14);
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
            this.radoBtnAllCustomer.ForeColor = System.Drawing.Color.Red;
            this.radoBtnAllCustomer.Location = new System.Drawing.Point(580, 14);
            this.radoBtnAllCustomer.Name = "radoBtnAllCustomer";
            this.radoBtnAllCustomer.Size = new System.Drawing.Size(88, 20);
            this.radoBtnAllCustomer.TabIndex = 0;
            this.radoBtnAllCustomer.TabStop = true;
            this.radoBtnAllCustomer.Text = "كل العملاء";
            this.radoBtnAllCustomer.UseVisualStyleBackColor = true;
            this.radoBtnAllCustomer.CheckedChanged += new System.EventHandler(this.radoBtnAllCustomer_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(307, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(191, 16);
            this.labelControl1.TabIndex = 64;
            this.labelControl1.Text = "المبالغ المسددة من قبل العملاء";
            // 
            // dgvDelayCustomers
            // 
            this.dgvDelayCustomers.AllowUserToResizeColumns = false;
            this.dgvDelayCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDelayCustomers.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelayCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDelayCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDelayCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDelayCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDelayCustomers.Location = new System.Drawing.Point(3, 81);
            this.dgvDelayCustomers.Name = "dgvDelayCustomers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelayCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDelayCustomers.RowHeadersWidth = 30;
            this.dgvDelayCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDelayCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDelayCustomers.Size = new System.Drawing.Size(765, 276);
            this.dgvDelayCustomers.TabIndex = 65;
            // 
            // txtTotalPayedValue
            // 
            this.txtTotalPayedValue.EnterMoveNextControl = true;
            this.txtTotalPayedValue.Location = new System.Drawing.Point(603, 365);
            this.txtTotalPayedValue.Name = "txtTotalPayedValue";
            this.txtTotalPayedValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtTotalPayedValue.Properties.Appearance.Options.UseFont = true;
            this.txtTotalPayedValue.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalPayedValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTotalPayedValue.Properties.ReadOnly = true;
            this.txtTotalPayedValue.Size = new System.Drawing.Size(165, 20);
            this.txtTotalPayedValue.TabIndex = 67;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(478, 365);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 19);
            this.labelControl2.TabIndex = 66;
            this.labelControl2.Text = "أجمالي المبالغ المسددة:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton1.Location = new System.Drawing.Point(37, 362);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(164, 30);
            this.simpleButton1.TabIndex = 68;
            this.simpleButton1.Text = "مسح هذه البيانات";
            // 
            // frmCustomerPayedValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 395);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtTotalPayedValue);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dgvDelayCustomers);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCustomerPayedValue";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبالغ المسددة من قبل العملاء";
            this.Load += new System.EventHandler(this.frmCustomerPayedValue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelayCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPayedValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkuSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.RadioButton radoBtnSpecifiedCustomer;
        private System.Windows.Forms.RadioButton radoBtnAllCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.DataGridView dgvDelayCustomers;
        private DevExpress.XtraEditors.TextEdit txtTotalPayedValue;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}