namespace Graduation.PL
{
    partial class Phones
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPhones = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.btnAddPhone = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditPhone = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeletePhone = new DevExpress.XtraEditors.SimpleButton();
            this.dgvPhones = new System.Windows.Forms.DataGridView();
            this.colPhones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPhones
            // 
            this.lblPhones.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhones.Appearance.Options.UseFont = true;
            this.lblPhones.Location = new System.Drawing.Point(180, 8);
            this.lblPhones.Name = "lblPhones";
            this.lblPhones.Size = new System.Drawing.Size(66, 14);
            this.lblPhones.TabIndex = 0;
            this.lblPhones.Text = "رقم الهاتف:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(3, 6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(169, 20);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Enabled = false;
            this.btnAddPhone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPhone.ImageOptions.Image")));
            this.btnAddPhone.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAddPhone.Location = new System.Drawing.Point(125, 27);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(60, 23);
            this.btnAddPhone.TabIndex = 2;
            this.btnAddPhone.Text = "اضافة";
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // btnEditPhone
            // 
            this.btnEditPhone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPhone.ImageOptions.Image")));
            this.btnEditPhone.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnEditPhone.Location = new System.Drawing.Point(64, 27);
            this.btnEditPhone.Name = "btnEditPhone";
            this.btnEditPhone.Size = new System.Drawing.Size(55, 23);
            this.btnEditPhone.TabIndex = 3;
            this.btnEditPhone.Text = "تعديل";
            this.btnEditPhone.Click += new System.EventHandler(this.btnEditPhone_Click);
            // 
            // btnDeletePhone
            // 
            this.btnDeletePhone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePhone.ImageOptions.Image")));
            this.btnDeletePhone.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnDeletePhone.Location = new System.Drawing.Point(3, 27);
            this.btnDeletePhone.Name = "btnDeletePhone";
            this.btnDeletePhone.Size = new System.Drawing.Size(56, 23);
            this.btnDeletePhone.TabIndex = 4;
            this.btnDeletePhone.Text = "حذف";
            this.btnDeletePhone.Click += new System.EventHandler(this.btnDeletePhone_Click);
            // 
            // dgvPhones
            // 
            this.dgvPhones.AllowUserToAddRows = false;
            this.dgvPhones.AllowUserToDeleteRows = false;
            this.dgvPhones.AllowUserToResizeColumns = false;
            this.dgvPhones.AllowUserToResizeRows = false;
            this.dgvPhones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPhones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPhones.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhones});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhones.Location = new System.Drawing.Point(3, 54);
            this.dgvPhones.MultiSelect = false;
            this.dgvPhones.Name = "dgvPhones";
            this.dgvPhones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhones.Size = new System.Drawing.Size(243, 94);
            this.dgvPhones.TabIndex = 5;
            this.dgvPhones.SelectionChanged += new System.EventHandler(this.dgvPhones_SelectionChanged);
            // 
            // colPhones
            // 
            this.colPhones.DataPropertyName = "phone";
            this.colPhones.HeaderText = "رقم الهاتف";
            this.colPhones.Name = "colPhones";
            this.colPhones.ReadOnly = true;
            this.colPhones.Width = 80;
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnNew.Location = new System.Drawing.Point(189, 27);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(54, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "جديد";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Phones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvPhones);
            this.Controls.Add(this.btnDeletePhone);
            this.Controls.Add(this.btnEditPhone);
            this.Controls.Add(this.btnAddPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhones);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Phones";
            this.Size = new System.Drawing.Size(248, 154);
            this.Load += new System.EventHandler(this.Phones_Load);
            this.Resize += new System.EventHandler(this.Phones_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblPhones;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.SimpleButton btnAddPhone;
        private DevExpress.XtraEditors.SimpleButton btnEditPhone;
        private DevExpress.XtraEditors.SimpleButton btnDeletePhone;
        private System.Windows.Forms.DataGridView dgvPhones;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhones;
    }
}
