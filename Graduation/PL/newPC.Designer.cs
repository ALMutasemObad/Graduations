using System;

namespace Graduation.PL
{
    partial class newPC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newPC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dicresButton = new DevExpress.XtraEditors.SimpleButton();
            this.incresButton = new DevExpress.XtraEditors.SimpleButton();
            this.quntitytextBox = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new DevExpress.XtraEditors.GroupControl();
            this.dateTextBox = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baraCodetextBox = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.idTextBox = new DevExpress.XtraEditors.TextEdit();
            this.RawMtGroupBox = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBox3 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new System.Windows.Forms.DataGridView();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quntitytextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baraCodetextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RawMtGroupBox)).BeginInit();
            this.RawMtGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم المنتج";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupControl1);
            this.groupBox2.Controls.Add(this.lookUpEdit1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(2, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 67);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات المنتج ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dicresButton);
            this.groupControl1.Controls.Add(this.incresButton);
            this.groupControl1.Controls.Add(this.quntitytextBox);
            this.groupControl1.Location = new System.Drawing.Point(6, 19);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(251, 43);
            this.groupControl1.TabIndex = 12;
            // 
            // dicresButton
            // 
            this.dicresButton.ImageOptions.SvgImage = global::Graduation.Properties.Resources.actions_remove;
            this.dicresButton.Location = new System.Drawing.Point(3, 4);
            this.dicresButton.Name = "dicresButton";
            this.dicresButton.Size = new System.Drawing.Size(38, 33);
            this.dicresButton.TabIndex = 14;
            this.dicresButton.Click += new System.EventHandler(this.dicresButton_Click);
            // 
            // incresButton
            // 
            this.incresButton.ImageOptions.SvgImage = global::Graduation.Properties.Resources.actions_addcircled;
            this.incresButton.Location = new System.Drawing.Point(206, 5);
            this.incresButton.Name = "incresButton";
            this.incresButton.Size = new System.Drawing.Size(40, 32);
            this.incresButton.TabIndex = 14;
            this.incresButton.Click += new System.EventHandler(this.incresButton_Click);
            // 
            // quntitytextBox
            // 
            this.quntitytextBox.EditValue = "5";
            this.quntitytextBox.Location = new System.Drawing.Point(75, 11);
            this.quntitytextBox.Name = "quntitytextBox";
            this.quntitytextBox.Size = new System.Drawing.Size(66, 20);
            this.quntitytextBox.TabIndex = 13;
            this.quntitytextBox.EditValueChanged += new System.EventHandler(this.quntitytextBox_EditValueChanged_1);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(341, 31);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "PRODUCTNAME";
            this.lookUpEdit1.Properties.NullText = "اختر منتج";
            this.lookUpEdit1.Properties.ShowFooter = false;
            this.lookUpEdit1.Properties.ShowHeader = false;
            this.lookUpEdit1.Properties.ShowLines = false;
            this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lookUpEdit1.Size = new System.Drawing.Size(229, 20);
            this.lookUpEdit1.TabIndex = 11;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(713, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.baraCodetextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 66);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.Text = "إضافة دورة أنتاجية جديدة";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(201, 31);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(176, 20);
            this.dateTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "تاريخ الدورة ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "معرف الدورة";
            // 
            // baraCodetextBox
            // 
            this.baraCodetextBox.Location = new System.Drawing.Point(9, 28);
            this.baraCodetextBox.Name = "baraCodetextBox";
            this.baraCodetextBox.Properties.ReadOnly = true;
            this.baraCodetextBox.Size = new System.Drawing.Size(100, 20);
            this.baraCodetextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "رمز الباراكود";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(464, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Properties.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // RawMtGroupBox
            // 
            this.RawMtGroupBox.AppearanceCaption.Options.UseTextOptions = true;
            this.RawMtGroupBox.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RawMtGroupBox.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RawMtGroupBox.CaptionImageOptions.Image")));
            this.RawMtGroupBox.Controls.Add(this.labelControl1);
            this.RawMtGroupBox.Controls.Add(this.textBox3);
            this.RawMtGroupBox.Controls.Add(this.gridControl1);
            this.RawMtGroupBox.Controls.Add(this.saveButton);
            this.RawMtGroupBox.Controls.Add(this.simpleButton2);
            this.RawMtGroupBox.Location = new System.Drawing.Point(2, 133);
            this.RawMtGroupBox.Name = "RawMtGroupBox";
            this.RawMtGroupBox.Size = new System.Drawing.Size(653, 444);
            this.RawMtGroupBox.TabIndex = 11;
            this.RawMtGroupBox.Text = "بيانات الدورة الأنتاجية الواحدة";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(493, 331);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 14);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "تكلفةالأنتاج:";
            // 
            // textBox3
            // 
            this.textBox3.EditValue = "0";
            this.textBox3.Location = new System.Drawing.Point(330, 326);
            this.textBox3.Name = "textBox3";
            this.textBox3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.textBox3.Properties.Appearance.Options.UseFont = true;
            this.textBox3.Properties.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(157, 22);
            this.textBox3.TabIndex = 10;
            // 
            // gridControl1
            // 
            this.gridControl1.AllowUserToAddRows = false;
            this.gridControl1.AllowUserToResizeColumns = false;
            this.gridControl1.AllowUserToResizeRows = false;
            this.gridControl1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridControl1.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridControl1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridControl1.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridControl1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridControl1.Location = new System.Drawing.Point(11, 40);
            this.gridControl1.MultiSelect = false;
            this.gridControl1.Name = "gridControl1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridControl1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridControl1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gridControl1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.gridControl1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridControl1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridControl1.Size = new System.Drawing.Size(637, 274);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridControl1_CellContentClick);
            // 
            // saveButton
            // 
            this.saveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.ImageOptions.Image")));
            this.saveButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.saveButton.Location = new System.Drawing.Point(112, 334);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 30);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "حفظ";
            this.saveButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton2.Location = new System.Drawing.Point(15, 334);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(91, 30);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "طباعة تقرير";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // newPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RawMtGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "newPC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة دورة أنتاجية ";
            this.Load += new System.EventHandler(this.newPC_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quntitytextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baraCodetextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RawMtGroupBox)).EndInit();
            this.RawMtGroupBox.ResumeLayout(false);
            this.RawMtGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

       
        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit quntitytextBox;
        private DevExpress.XtraEditors.GroupControl RawMtGroupBox;
        private System.Windows.Forms.DataGridView gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textBox3;
        private DevExpress.XtraEditors.GroupControl groupBox1;
        private System.Windows.Forms.DateTimePicker dateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit baraCodetextBox;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit idTextBox;
        private DevExpress.XtraEditors.SimpleButton incresButton;
        private DevExpress.XtraEditors.SimpleButton dicresButton;
    }
}