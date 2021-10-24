namespace Graduation.PL
{
    partial class newBond
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
            this.primryGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.custmerNLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bondIDtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.detilsGroupBox = new System.Windows.Forms.GroupBox();
            this.bandTypeComboBox = new System.Windows.Forms.ComboBox();
            this.imgGroupBox = new System.Windows.Forms.GroupBox();
            this.descTextBox = new System.Windows.Forms.RichTextBox();
            this.valueBondtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateGroupBox = new System.Windows.Forms.GroupBox();
            this.valditycomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.oprtionsGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.dataSet1 = new Graduation.DataSet1();
            this.cUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERSTableAdapter = new Graduation.DataSet1TableAdapters.CUSTOMERSTableAdapter();
            this.primryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custmerNLookUpEdit.Properties)).BeginInit();
            this.detilsGroupBox.SuspendLayout();
            this.dateGroupBox.SuspendLayout();
            this.oprtionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // primryGroupBox
            // 
            this.primryGroupBox.Controls.Add(this.label9);
            this.primryGroupBox.Controls.Add(this.custmerNLookUpEdit);
            this.primryGroupBox.Controls.Add(this.dateTextBox);
            this.primryGroupBox.Controls.Add(this.label3);
            this.primryGroupBox.Controls.Add(this.bondIDtextBox);
            this.primryGroupBox.Controls.Add(this.label2);
            this.primryGroupBox.Controls.Add(this.label1);
            this.primryGroupBox.Location = new System.Drawing.Point(12, 12);
            this.primryGroupBox.Name = "primryGroupBox";
            this.primryGroupBox.Size = new System.Drawing.Size(539, 75);
            this.primryGroupBox.TabIndex = 0;
            this.primryGroupBox.TabStop = false;
            this.primryGroupBox.Text = "معلومات اساسية ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(209, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "هل تريد اظافة عميل جديد؟";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // custmerNLookUpEdit
            // 
            this.custmerNLookUpEdit.Location = new System.Drawing.Point(188, 27);
            this.custmerNLookUpEdit.Name = "custmerNLookUpEdit";
            this.custmerNLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.custmerNLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUSTOMER_ID", "CUSTOMER_ID", 5, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FULLNAME", "FULLNAME", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.custmerNLookUpEdit.Properties.DataSource = this.cUSTOMERSBindingSource;
            this.custmerNLookUpEdit.Properties.DisplayMember = "FULLNAME";
            this.custmerNLookUpEdit.Properties.NullText = "ابحث عن العميل";
            this.custmerNLookUpEdit.Properties.ShowFooter = false;
            this.custmerNLookUpEdit.Properties.ShowHeader = false;
            this.custmerNLookUpEdit.Properties.ShowLines = false;
            this.custmerNLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.custmerNLookUpEdit.Properties.ValueMember = "CUSTOMER_ID";
            this.custmerNLookUpEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.custmerNLookUpEdit.Size = new System.Drawing.Size(150, 20);
            this.custmerNLookUpEdit.TabIndex = 12;
            this.custmerNLookUpEdit.EditValueChanged += new System.EventHandler(this.custmerNLookUpEdit_EditValueChanged);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Enabled = false;
            this.dateTextBox.Location = new System.Drawing.Point(6, 27);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(126, 20);
            this.dateTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "تاريخ الرهن";
            // 
            // bondIDtextBox
            // 
            this.bondIDtextBox.Enabled = false;
            this.bondIDtextBox.Location = new System.Drawing.Point(407, 27);
            this.bondIDtextBox.Name = "bondIDtextBox";
            this.bondIDtextBox.Size = new System.Drawing.Size(63, 20);
            this.bondIDtextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم العميل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الرهن";
            // 
            // detilsGroupBox
            // 
            this.detilsGroupBox.Controls.Add(this.bandTypeComboBox);
            this.detilsGroupBox.Controls.Add(this.imgGroupBox);
            this.detilsGroupBox.Controls.Add(this.descTextBox);
            this.detilsGroupBox.Controls.Add(this.valueBondtextBox);
            this.detilsGroupBox.Controls.Add(this.label5);
            this.detilsGroupBox.Controls.Add(this.label4);
            this.detilsGroupBox.Controls.Add(this.label6);
            this.detilsGroupBox.Enabled = false;
            this.detilsGroupBox.Location = new System.Drawing.Point(12, 83);
            this.detilsGroupBox.Name = "detilsGroupBox";
            this.detilsGroupBox.Size = new System.Drawing.Size(539, 181);
            this.detilsGroupBox.TabIndex = 1;
            this.detilsGroupBox.TabStop = false;
            this.detilsGroupBox.Text = "تفاصيل الرهن";
            // 
            // bandTypeComboBox
            // 
            this.bandTypeComboBox.FormattingEnabled = true;
            this.bandTypeComboBox.Items.AddRange(new object[] {
            "زهب ",
            "سلاح"});
            this.bandTypeComboBox.Location = new System.Drawing.Point(370, 57);
            this.bandTypeComboBox.Name = "bandTypeComboBox";
            this.bandTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.bandTypeComboBox.TabIndex = 3;
            this.bandTypeComboBox.Text = "حدد نوع الرهن";
            this.bandTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.bandTypeComboBox_SelectedIndexChanged);
            // 
            // imgGroupBox
            // 
            this.imgGroupBox.Location = new System.Drawing.Point(6, 39);
            this.imgGroupBox.Name = "imgGroupBox";
            this.imgGroupBox.Size = new System.Drawing.Size(161, 130);
            this.imgGroupBox.TabIndex = 2;
            this.imgGroupBox.TabStop = false;
            this.imgGroupBox.Text = "صورة الرهن";
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(176, 93);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(294, 76);
            this.descTextBox.TabIndex = 1;
            this.descTextBox.Text = "";
            // 
            // valueBondtextBox
            // 
            this.valueBondtextBox.Location = new System.Drawing.Point(176, 57);
            this.valueBondtextBox.Name = "valueBondtextBox";
            this.valueBondtextBox.Size = new System.Drawing.Size(72, 20);
            this.valueBondtextBox.TabIndex = 1;
            this.valueBondtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valueBondtextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "وصف الرهن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "نوع الرهن";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "السعر التقديري للرهن";
            // 
            // dateGroupBox
            // 
            this.dateGroupBox.Controls.Add(this.valditycomboBox);
            this.dateGroupBox.Controls.Add(this.label8);
            this.dateGroupBox.Controls.Add(this.dateTimePicker1);
            this.dateGroupBox.Controls.Add(this.label7);
            this.dateGroupBox.Enabled = false;
            this.dateGroupBox.Location = new System.Drawing.Point(13, 270);
            this.dateGroupBox.Name = "dateGroupBox";
            this.dateGroupBox.Size = new System.Drawing.Size(538, 75);
            this.dateGroupBox.TabIndex = 2;
            this.dateGroupBox.TabStop = false;
            // 
            // valditycomboBox
            // 
            this.valditycomboBox.Enabled = false;
            this.valditycomboBox.FormattingEnabled = true;
            this.valditycomboBox.Items.AddRange(new object[] {
            "شهر",
            "ثلاثة اشهر",
            "ستة اشهر",
            "سنة"});
            this.valditycomboBox.Location = new System.Drawing.Point(28, 31);
            this.valditycomboBox.Name = "valditycomboBox";
            this.valditycomboBox.Size = new System.Drawing.Size(111, 21);
            this.valditycomboBox.TabIndex = 4;
            this.valditycomboBox.Text = "المدة قبل المصادرة";
            this.valditycomboBox.SelectedIndexChanged += new System.EventHandler(this.valditycomboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "صلاحية الرهن";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(275, 32);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "موعد تسديد الدين";
            // 
            // oprtionsGroupBox
            // 
            this.oprtionsGroupBox.Controls.Add(this.saveButton);
            this.oprtionsGroupBox.Enabled = false;
            this.oprtionsGroupBox.Location = new System.Drawing.Point(377, 356);
            this.oprtionsGroupBox.Name = "oprtionsGroupBox";
            this.oprtionsGroupBox.Size = new System.Drawing.Size(174, 62);
            this.oprtionsGroupBox.TabIndex = 3;
            this.oprtionsGroupBox.TabStop = false;
            this.oprtionsGroupBox.Enter += new System.EventHandler(this.oprtionsGroupBox_Enter);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 22);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "حفظ الرهن";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(26, 395);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "تراجع ";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERSBindingSource
            // 
            this.cUSTOMERSBindingSource.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource.DataSource = this.dataSet1;
            // 
            // cUSTOMERSTableAdapter
            // 
            this.cUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // newBond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 433);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.oprtionsGroupBox);
            this.Controls.Add(this.dateGroupBox);
            this.Controls.Add(this.detilsGroupBox);
            this.Controls.Add(this.primryGroupBox);
            this.Name = "newBond";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "رهن جديد";
            this.Load += new System.EventHandler(this.newBond_Load);
            this.primryGroupBox.ResumeLayout(false);
            this.primryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custmerNLookUpEdit.Properties)).EndInit();
            this.detilsGroupBox.ResumeLayout(false);
            this.detilsGroupBox.PerformLayout();
            this.dateGroupBox.ResumeLayout(false);
            this.dateGroupBox.PerformLayout();
            this.oprtionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox primryGroupBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bondIDtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox detilsGroupBox;
        private System.Windows.Forms.GroupBox imgGroupBox;
        private System.Windows.Forms.RichTextBox descTextBox;
        private System.Windows.Forms.TextBox valueBondtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox dateGroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox oprtionsGroupBox;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DataSet4TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.ComboBox bandTypeComboBox;
        private System.Windows.Forms.ComboBox valditycomboBox;
        private System.Windows.Forms.Label label9;
        public DevExpress.XtraEditors.LookUpEdit custmerNLookUpEdit;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource;
        private DataSet1TableAdapters.CUSTOMERSTableAdapter cUSTOMERSTableAdapter;
    }
}