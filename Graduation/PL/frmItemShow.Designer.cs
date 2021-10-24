namespace Graduation.PL
{
    partial class frmItemShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemShow));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd1 = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkeSearchItems = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCategory = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteAllProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteSpecificProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNewProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewAllProducts = new DevExpress.XtraEditors.SimpleButton();
            this.txtRetailPrice = new DevExpress.XtraEditors.MemoEdit();
            this.txtWholePrice = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtQty = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeSearchItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetailPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWholePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.dgvProducts);
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(839, 288);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "بيانات المنتجات";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToOrderColumns = true;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProducts.Location = new System.Drawing.Point(2, 21);
            this.dgvProducts.Name = "dgvProducts";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.RowHeadersWidth = 30;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(835, 265);
            this.dgvProducts.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtSearch);
            this.panelControl1.Controls.Add(this.btnAdd2);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.btnAdd1);
            this.panelControl1.Controls.Add(this.lookUpEdit2);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lkeSearchItems);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(0, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelControl1.Size = new System.Drawing.Size(837, 44);
            this.panelControl1.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(581, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 20);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged);
            // 
            // btnAdd2
            // 
            this.btnAdd2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd2.ImageOptions.Image")));
            this.btnAdd2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAdd2.Location = new System.Drawing.Point(270, 9);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(31, 23);
            this.btnAdd2.TabIndex = 20;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton2.Location = new System.Drawing.Point(9, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(31, 23);
            this.simpleButton2.TabIndex = 19;
            // 
            // btnAdd1
            // 
            this.btnAdd1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd1.ImageOptions.Image")));
            this.btnAdd1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAdd1.Location = new System.Drawing.Point(547, 8);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(31, 23);
            this.btnAdd1.TabIndex = 17;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.EditValue = "";
            this.lookUpEdit2.Location = new System.Drawing.Point(41, 11);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit2.Size = new System.Drawing.Size(155, 20);
            this.lookUpEdit2.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(202, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "بحث بالباركود:";
            // 
            // lkeSearchItems
            // 
            this.lkeSearchItems.EditValue = "";
            this.lkeSearchItems.Location = new System.Drawing.Point(302, 11);
            this.lkeSearchItems.Name = "lkeSearchItems";
            this.lkeSearchItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeSearchItems.Properties.ShowHeader = false;
            this.lkeSearchItems.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkeSearchItems.Size = new System.Drawing.Size(155, 20);
            this.lkeSearchItems.TabIndex = 14;
            this.lkeSearchItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lkeSearchItems_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(461, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "بجث باسم المنتج:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(755, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "بحث بالكلمة:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnRefresh);
            this.panelControl2.Controls.Add(this.btnAddCategory);
            this.panelControl2.Controls.Add(this.btnDeleteAllProduct);
            this.panelControl2.Controls.Add(this.btnDeleteSpecificProduct);
            this.panelControl2.Controls.Add(this.btnEditProduct);
            this.panelControl2.Controls.Add(this.btnAddNewProduct);
            this.panelControl2.Controls.Add(this.btnViewAllProducts);
            this.panelControl2.Controls.Add(this.txtRetailPrice);
            this.panelControl2.Controls.Add(this.txtWholePrice);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.txtQty);
            this.panelControl2.Location = new System.Drawing.Point(0, 337);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(839, 83);
            this.panelControl2.TabIndex = 11;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnRefresh.Location = new System.Drawing.Point(9, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 28);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "إفراغ القائمة";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.ImageOptions.Image")));
            this.btnAddCategory.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAddCategory.Location = new System.Drawing.Point(7, 42);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(113, 28);
            this.btnAddCategory.TabIndex = 23;
            this.btnAddCategory.Text = "اضافة مجموعه";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnDeleteAllProduct
            // 
            this.btnDeleteAllProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllProduct.ImageOptions.Image")));
            this.btnDeleteAllProduct.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnDeleteAllProduct.Location = new System.Drawing.Point(134, 42);
            this.btnDeleteAllProduct.Name = "btnDeleteAllProduct";
            this.btnDeleteAllProduct.Size = new System.Drawing.Size(113, 28);
            this.btnDeleteAllProduct.TabIndex = 22;
            this.btnDeleteAllProduct.Text = "مسح كل المنتجات";
            // 
            // btnDeleteSpecificProduct
            // 
            this.btnDeleteSpecificProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSpecificProduct.ImageOptions.Image")));
            this.btnDeleteSpecificProduct.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnDeleteSpecificProduct.Location = new System.Drawing.Point(262, 42);
            this.btnDeleteSpecificProduct.Name = "btnDeleteSpecificProduct";
            this.btnDeleteSpecificProduct.Size = new System.Drawing.Size(123, 28);
            this.btnDeleteSpecificProduct.TabIndex = 21;
            this.btnDeleteSpecificProduct.Text = "مسح المنتج المحدد";
            this.btnDeleteSpecificProduct.Click += new System.EventHandler(this.btnDeleteSpecificProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditProduct.ImageOptions.Image")));
            this.btnEditProduct.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnEditProduct.Location = new System.Drawing.Point(404, 42);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(113, 28);
            this.btnEditProduct.TabIndex = 20;
            this.btnEditProduct.Text = "تعديل المنتج";
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewProduct.ImageOptions.Image")));
            this.btnAddNewProduct.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAddNewProduct.Location = new System.Drawing.Point(540, 42);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(113, 28);
            this.btnAddNewProduct.TabIndex = 19;
            this.btnAddNewProduct.Text = "اضافة منتج جديد";
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnViewAllProducts
            // 
            this.btnViewAllProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewAllProducts.ImageOptions.Image")));
            this.btnViewAllProducts.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnViewAllProducts.Location = new System.Drawing.Point(677, 42);
            this.btnViewAllProducts.Name = "btnViewAllProducts";
            this.btnViewAllProducts.Size = new System.Drawing.Size(113, 28);
            this.btnViewAllProducts.TabIndex = 18;
            this.btnViewAllProducts.Text = "عرض كل المنتجات";
            this.btnViewAllProducts.Click += new System.EventHandler(this.btnViewAllProducts_Click);
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.Location = new System.Drawing.Point(96, 4);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Properties.ReadOnly = true;
            this.txtRetailPrice.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRetailPrice.Size = new System.Drawing.Size(100, 29);
            this.txtRetailPrice.TabIndex = 17;
            // 
            // txtWholePrice
            // 
            this.txtWholePrice.Location = new System.Drawing.Point(414, 4);
            this.txtWholePrice.Name = "txtWholePrice";
            this.txtWholePrice.Properties.ReadOnly = true;
            this.txtWholePrice.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWholePrice.Size = new System.Drawing.Size(100, 29);
            this.txtWholePrice.TabIndex = 16;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(520, 6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "اجمالي بيع الجملة:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(202, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(88, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "أجمالي بيع التجزئة:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(747, 7);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "الكميــة:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(639, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.ReadOnly = true;
            this.txtQty.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.Size = new System.Drawing.Size(100, 29);
            this.txtQty.TabIndex = 13;
            // 
            // frmItemShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 426);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmItemShow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض الأصناف";
            this.Load += new System.EventHandler(this.frmItemShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeSearchItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetailPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWholePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lkeSearchItems;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnViewAllProducts;
        private DevExpress.XtraEditors.MemoEdit txtRetailPrice;
        private DevExpress.XtraEditors.MemoEdit txtWholePrice;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit txtQty;
        private DevExpress.XtraEditors.SimpleButton btnAddNewProduct;
        private DevExpress.XtraEditors.SimpleButton btnAddCategory;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAllProduct;
        private DevExpress.XtraEditors.SimpleButton btnDeleteSpecificProduct;
        private DevExpress.XtraEditors.SimpleButton btnEditProduct;
        private DevExpress.XtraEditors.SimpleButton btnAdd2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.TextEdit txtSearch;

    }
}