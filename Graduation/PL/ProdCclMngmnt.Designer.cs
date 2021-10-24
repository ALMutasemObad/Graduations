namespace Graduation.PL
{
    partial class ProdCclMngmnt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdCclMngmnt));
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.dateSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.IDsearchControl = new DevExpress.XtraEditors.SearchControl();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.updeatGroupBox1 = new DevExpress.XtraEditors.GroupControl();
            this.exit = new DevExpress.XtraEditors.SimpleButton();
            this.New = new DevExpress.XtraEditors.SimpleButton();
            this.delete = new DevExpress.XtraEditors.SimpleButton();
            this.update = new DevExpress.XtraEditors.SimpleButton();
            this.searchGroupBox.SuspendLayout();
            this.dateSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDsearchControl.Properties)).BeginInit();
            this.resultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updeatGroupBox1)).BeginInit();
            this.updeatGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.dateCheckBox);
            this.searchGroupBox.Controls.Add(this.dateSearchGroupBox);
            this.searchGroupBox.Controls.Add(this.IDsearchControl);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 12);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(634, 91);
            this.searchGroupBox.TabIndex = 0;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "البحث عن الدورة الانتاجية ";
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(423, 62);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(176, 17);
            this.dateCheckBox.TabIndex = 2;
            this.dateCheckBox.Text = "هل تريد البحث  باستخدام التاريخ ";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckStateChanged += new System.EventHandler(this.dateCheckBox_CheckStateChanged);
            this.dateCheckBox.Click += new System.EventHandler(this.dateCheckBox_Click);
            // 
            // dateSearchGroupBox
            // 
            this.dateSearchGroupBox.Controls.Add(this.label2);
            this.dateSearchGroupBox.Controls.Add(this.label1);
            this.dateSearchGroupBox.Controls.Add(this.endDate);
            this.dateSearchGroupBox.Controls.Add(this.startDate);
            this.dateSearchGroupBox.Location = new System.Drawing.Point(8, 20);
            this.dateSearchGroupBox.Name = "dateSearchGroupBox";
            this.dateSearchGroupBox.Size = new System.Drawing.Size(371, 59);
            this.dateSearchGroupBox.TabIndex = 1;
            this.dateSearchGroupBox.TabStop = false;
            this.dateSearchGroupBox.Text = "بحث حسب التاريخ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "من:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "الى:";
            // 
            // endDate
            // 
            this.endDate.Enabled = false;
            this.endDate.Location = new System.Drawing.Point(18, 16);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(123, 20);
            this.endDate.TabIndex = 0;
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(189, 16);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(115, 20);
            this.startDate.TabIndex = 0;
            this.startDate.Value = new System.DateTime(2019, 6, 17, 22, 5, 0, 0);
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // IDsearchControl
            // 
            this.IDsearchControl.EditValue = "ادخل الرقم التسلسلي للمنتج";
            this.IDsearchControl.Location = new System.Drawing.Point(397, 36);
            this.IDsearchControl.Name = "IDsearchControl";
            this.IDsearchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.IDsearchControl.Size = new System.Drawing.Size(202, 20);
            this.IDsearchControl.TabIndex = 0;
            this.IDsearchControl.SelectedIndexChanged += new System.EventHandler(this.IDsearchControl_SelectedIndexChanged);
            this.IDsearchControl.TextChanged += new System.EventHandler(this.IDsearchControl_TextChanged);
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.dataGridView);
            this.resultGroupBox.Location = new System.Drawing.Point(12, 109);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(634, 389);
            this.resultGroupBox.TabIndex = 0;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "بيانات الدورات الانتاجية ";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(15, 22);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(610, 285);
            this.dataGridView.TabIndex = 54;
            // 
            // updeatGroupBox1
            // 
            this.updeatGroupBox1.Controls.Add(this.exit);
            this.updeatGroupBox1.Controls.Add(this.New);
            this.updeatGroupBox1.Controls.Add(this.delete);
            this.updeatGroupBox1.Controls.Add(this.update);
            this.updeatGroupBox1.Location = new System.Drawing.Point(12, 504);
            this.updeatGroupBox1.Name = "updeatGroupBox1";
            this.updeatGroupBox1.ShowCaption = false;
            this.updeatGroupBox1.Size = new System.Drawing.Size(634, 65);
            this.updeatGroupBox1.TabIndex = 55;
            this.updeatGroupBox1.Text = "groupControl1";
            // 
            // exit
            // 
            this.exit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Appearance.Options.UseFont = true;
            this.exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("exit.ImageOptions.Image")));
            this.exit.Location = new System.Drawing.Point(251, 18);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(106, 35);
            this.exit.TabIndex = 54;
            this.exit.Text = "خروج";
            // 
            // New
            // 
            this.New.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Appearance.Options.UseFont = true;
            this.New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("New.ImageOptions.Image")));
            this.New.Location = new System.Drawing.Point(403, 18);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(106, 34);
            this.New.TabIndex = 55;
            this.New.Text = "جديد";
            this.New.Click += new System.EventHandler(this.New_Click_1);
            // 
            // delete
            // 
            this.delete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Appearance.Options.UseFont = true;
            this.delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("delete.ImageOptions.Image")));
            this.delete.Location = new System.Drawing.Point(5, 18);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(106, 32);
            this.delete.TabIndex = 56;
            this.delete.Text = "حذف";
            // 
            // update
            // 
            this.update.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Appearance.Options.UseFont = true;
            this.update.Enabled = false;
            this.update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("update.ImageOptions.Image")));
            this.update.Location = new System.Drawing.Point(118, 20);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(106, 33);
            this.update.TabIndex = 53;
            this.update.Text = "تعديل";
            // 
            // ProdCclMngmnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 581);
            this.Controls.Add(this.updeatGroupBox1);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ProdCclMngmnt";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الدورات الانتاجية ";
            this.Load += new System.EventHandler(this.ProdCclMngmnt_Load);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.dateSearchGroupBox.ResumeLayout(false);
            this.dateSearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDsearchControl.Properties)).EndInit();
            this.resultGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updeatGroupBox1)).EndInit();
            this.updeatGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.GroupBox dateSearchGroupBox;
        private DevExpress.XtraEditors.SearchControl IDsearchControl;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private DevExpress.XtraEditors.GroupControl updeatGroupBox1;
        private DevExpress.XtraEditors.SimpleButton exit;
        private DevExpress.XtraEditors.SimpleButton New;
        private DevExpress.XtraEditors.SimpleButton delete;
        private DevExpress.XtraEditors.SimpleButton update;
    }
}