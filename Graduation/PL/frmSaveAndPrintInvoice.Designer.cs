namespace Graduation.PL
{
    partial class frmSaveAndPrintInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaveAndPrintInvoice));
            this.btnSaveAndPrintInvoice = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtRemainedValue = new DevExpress.XtraEditors.TextEdit();
            this.txtPayedValue = new DevExpress.XtraEditors.TextEdit();
            this.txtRequestedValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemainedValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayedValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequestedValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveAndPrintInvoice
            // 
            this.btnSaveAndPrintInvoice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAndPrintInvoice.ImageOptions.Image")));
            this.btnSaveAndPrintInvoice.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSaveAndPrintInvoice.Location = new System.Drawing.Point(17, 187);
            this.btnSaveAndPrintInvoice.Name = "btnSaveAndPrintInvoice";
            this.btnSaveAndPrintInvoice.Size = new System.Drawing.Size(189, 37);
            this.btnSaveAndPrintInvoice.TabIndex = 17;
            this.btnSaveAndPrintInvoice.Text = "لحفظ وطباعة الفاتورة";
            this.btnSaveAndPrintInvoice.Click += new System.EventHandler(this.btnSaveAndPrintInvoice_Click);
            // 
            // btnBack
            // 
            this.btnBack.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.ImageOptions.Image")));
            this.btnBack.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnBack.Location = new System.Drawing.Point(212, 187);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 37);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "رجوع";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(224, 227);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(62, 25);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "F12";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.Enabled = false;
            this.simpleButton2.Location = new System.Drawing.Point(88, 226);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(62, 25);
            this.simpleButton2.TabIndex = 23;
            this.simpleButton2.Text = "Enter";
            // 
            // txtRemainedValue
            // 
            this.txtRemainedValue.EnterMoveNextControl = true;
            this.txtRemainedValue.Location = new System.Drawing.Point(96, 155);
            this.txtRemainedValue.Name = "txtRemainedValue";
            this.txtRemainedValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtRemainedValue.Properties.Appearance.Options.UseFont = true;
            this.txtRemainedValue.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRemainedValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtRemainedValue.Properties.ReadOnly = true;
            this.txtRemainedValue.Size = new System.Drawing.Size(182, 26);
            this.txtRemainedValue.TabIndex = 28;
            // 
            // txtPayedValue
            // 
            this.txtPayedValue.EnterMoveNextControl = true;
            this.txtPayedValue.Location = new System.Drawing.Point(96, 123);
            this.txtPayedValue.Name = "txtPayedValue";
            this.txtPayedValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPayedValue.Properties.Appearance.Options.UseFont = true;
            this.txtPayedValue.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPayedValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPayedValue.Size = new System.Drawing.Size(182, 26);
            this.txtPayedValue.TabIndex = 25;
            this.txtPayedValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPayedValue_KeyDown);
            this.txtPayedValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayedValue_KeyPress);
            // 
            // txtRequestedValue
            // 
            this.txtRequestedValue.EnterMoveNextControl = true;
            this.txtRequestedValue.Location = new System.Drawing.Point(96, 91);
            this.txtRequestedValue.Name = "txtRequestedValue";
            this.txtRequestedValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtRequestedValue.Properties.Appearance.Options.UseFont = true;
            this.txtRequestedValue.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRequestedValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtRequestedValue.Properties.ReadOnly = true;
            this.txtRequestedValue.Size = new System.Drawing.Size(182, 26);
            this.txtRequestedValue.TabIndex = 24;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 161);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 16);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "البــــاقي:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 129);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 16);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "المدفــوع:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 94);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 16);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "المطلــوب:";
            // 
            // frmSaveAndPrintInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 267);
            this.Controls.Add(this.txtRemainedValue);
            this.Controls.Add(this.txtPayedValue);
            this.Controls.Add(this.txtRequestedValue);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveAndPrintInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSaveAndPrintInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSaveAndPrintInvoice";
            this.Load += new System.EventHandler(this.frmSaveAndPrintInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRemainedValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayedValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequestedValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSaveAndPrintInvoice;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit txtRemainedValue;
        private DevExpress.XtraEditors.TextEdit txtPayedValue;
        private DevExpress.XtraEditors.TextEdit txtRequestedValue;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}