namespace Graduation.PL
{
    partial class FRM_USERS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_USERS));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.rdoUser = new System.Windows.Forms.RadioButton();
            this.rdoEmployee = new System.Windows.Forms.RadioButton();
            this.cmbEmp = new DevExpress.XtraEditors.LookUpEdit();
            this.btnNewUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddUser = new DevExpress.XtraEditors.SimpleButton();
            this.cbxShowPassword = new System.Windows.Forms.CheckBox();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rdoNotActive = new System.Windows.Forms.RadioButton();
            this.rdoActive = new System.Windows.Forms.RadioButton();
            this.txtPassWord = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.cmbEmp);
            this.groupControl1.Controls.Add(this.btnNewUser);
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnDeleteUser);
            this.groupControl1.Controls.Add(this.btnEditUser);
            this.groupControl1.Controls.Add(this.btnAddUser);
            this.groupControl1.Controls.Add(this.cbxShowPassword);
            this.groupControl1.Controls.Add(this.txtSearch);
            this.groupControl1.Controls.Add(this.cbxActive);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.dgvUsers);
            this.groupControl1.Controls.Add(this.rdoNotActive);
            this.groupControl1.Controls.Add(this.rdoActive);
            this.groupControl1.Controls.Add(this.txtPassWord);
            this.groupControl1.Controls.Add(this.txtUserName);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(759, 311);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "المستخدمــين";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.rdoUser);
            this.panelControl1.Controls.Add(this.rdoEmployee);
            this.panelControl1.Location = new System.Drawing.Point(197, 52);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(182, 24);
            this.panelControl1.TabIndex = 20;
            // 
            // rdoUser
            // 
            this.rdoUser.AutoSize = true;
            this.rdoUser.Location = new System.Drawing.Point(7, 4);
            this.rdoUser.Name = "rdoUser";
            this.rdoUser.Size = new System.Drawing.Size(102, 17);
            this.rdoUser.TabIndex = 15;
            this.rdoUser.Text = " أسم المستخدم";
            this.rdoUser.UseVisualStyleBackColor = true;
            // 
            // rdoEmployee
            // 
            this.rdoEmployee.AutoSize = true;
            this.rdoEmployee.Checked = true;
            this.rdoEmployee.Location = new System.Drawing.Point(113, 5);
            this.rdoEmployee.Name = "rdoEmployee";
            this.rdoEmployee.Size = new System.Drawing.Size(60, 17);
            this.rdoEmployee.TabIndex = 14;
            this.rdoEmployee.TabStop = true;
            this.rdoEmployee.Text = "الموظف";
            this.rdoEmployee.UseVisualStyleBackColor = true;
            // 
            // cmbEmp
            // 
            this.cmbEmp.AllowDrop = true;
            this.cmbEmp.EditValue = "";
            this.cmbEmp.EnterMoveNextControl = true;
            this.cmbEmp.Location = new System.Drawing.Point(448, 85);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEmp.Properties.ShowFooter = false;
            this.cmbEmp.Properties.ShowHeader = false;
            this.cmbEmp.Properties.ShowLines = false;
            this.cmbEmp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbEmp.Size = new System.Drawing.Size(223, 20);
            this.cmbEmp.TabIndex = 1;
            // 
            // btnNewUser
            // 
            this.btnNewUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewUser.ImageOptions.Image")));
            this.btnNewUser.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnNewUser.Location = new System.Drawing.Point(634, 260);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(113, 40);
            this.btnNewUser.TabIndex = 18;
            this.btnNewUser.Text = "مستخدم جديد";
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnClose.Location = new System.Drawing.Point(12, 260);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 40);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.ImageOptions.Image")));
            this.btnDeleteUser.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnDeleteUser.Location = new System.Drawing.Point(217, 260);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(113, 40);
            this.btnDeleteUser.TabIndex = 17;
            this.btnDeleteUser.Text = "حذف مستخدم";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUser.ImageOptions.Image")));
            this.btnEditUser.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnEditUser.Location = new System.Drawing.Point(375, 260);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(113, 40);
            this.btnEditUser.TabIndex = 16;
            this.btnEditUser.Text = "تعديل البياات";
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.ImageOptions.Image")));
            this.btnAddUser.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAddUser.Location = new System.Drawing.Point(509, 260);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(113, 40);
            this.btnAddUser.TabIndex = 15;
            this.btnAddUser.Text = "اضافة مستخدم";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click_1);
            // 
            // cbxShowPassword
            // 
            this.cbxShowPassword.AutoSize = true;
            this.cbxShowPassword.Location = new System.Drawing.Point(20, 56);
            this.cbxShowPassword.Name = "cbxShowPassword";
            this.cbxShowPassword.Size = new System.Drawing.Size(110, 17);
            this.cbxShowPassword.TabIndex = 14;
            this.cbxShowPassword.Text = "أظهار كلمات المرور";
            this.cbxShowPassword.UseVisualStyleBackColor = true;
            this.cbxShowPassword.CheckedChanged += new System.EventHandler(this.cbxShowPassword_CheckedChanged_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(424, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged);
            // 
            // cbxActive
            // 
            this.cbxActive.Checked = true;
            this.cbxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActive.Location = new System.Drawing.Point(144, 54);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(47, 17);
            this.cbxActive.TabIndex = 12;
            this.cbxActive.Text = "فعال";
            this.cbxActive.ThreeState = true;
            this.cbxActive.UseVisualStyleBackColor = true;
            this.cbxActive.CheckStateChanged += new System.EventHandler(this.cbxActive_CheckStateChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial Black", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(385, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 23);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "بحــــــث:";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.ColPass,
            this.Column3});
            this.dgvUsers.Location = new System.Drawing.Point(12, 98);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dgvUsers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsers.Size = new System.Drawing.Size(425, 154);
            this.dgvUsers.TabIndex = 14;
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "employee_number";
            this.Column4.HeaderText = "رقم الموظف";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "employee_name";
            this.Column1.HeaderText = "الموظف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "User_Name";
            this.Column2.HeaderText = "أسم المستخدم";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ColPass
            // 
            this.ColPass.DataPropertyName = "Password";
            this.ColPass.HeaderText = "كلمة المرور";
            this.ColPass.Name = "ColPass";
            this.ColPass.ReadOnly = true;
            this.ColPass.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "is_active";
            this.Column3.HeaderText = "فعال";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rdoNotActive
            // 
            this.rdoNotActive.AutoSize = true;
            this.rdoNotActive.Location = new System.Drawing.Point(533, 164);
            this.rdoNotActive.Name = "rdoNotActive";
            this.rdoNotActive.Size = new System.Drawing.Size(65, 17);
            this.rdoNotActive.TabIndex = 8;
            this.rdoNotActive.Text = "غير فعال";
            this.rdoNotActive.UseVisualStyleBackColor = true;
            // 
            // rdoActive
            // 
            this.rdoActive.AutoSize = true;
            this.rdoActive.Location = new System.Drawing.Point(613, 164);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.Size = new System.Drawing.Size(46, 17);
            this.rdoActive.TabIndex = 7;
            this.rdoActive.Text = "فعال";
            this.rdoActive.UseVisualStyleBackColor = true;
            // 
            // txtPassWord
            // 
            this.txtPassWord.EnterMoveNextControl = true;
            this.txtPassWord.Location = new System.Drawing.Point(448, 136);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Properties.PasswordChar = '*';
            this.txtPassWord.Properties.UseSystemPasswordChar = true;
            this.txtPassWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassWord.Size = new System.Drawing.Size(223, 20);
            this.txtPassWord.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.EnterMoveNextControl = true;
            this.txtUserName.Location = new System.Drawing.Point(448, 110);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.Size = new System.Drawing.Size(223, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial Black", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(677, 162);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 23);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "حالة المستخدم:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial Black", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(686, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 23);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "كلمة المرور:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Black", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(681, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 23);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "أسم المستخدم:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Black", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(705, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "الموظف:";
            // 
            // FRM_USERS
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 311);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FRM_USERS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المستخدمين";
            this.Load += new System.EventHandler(this.FRM_USERS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RadioButton rdoUser;
        private System.Windows.Forms.RadioButton rdoEmployee;
        private DevExpress.XtraEditors.LookUpEdit cmbEmp;
        private DevExpress.XtraEditors.SimpleButton btnNewUser;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDeleteUser;
        private DevExpress.XtraEditors.SimpleButton btnEditUser;
        private DevExpress.XtraEditors.SimpleButton btnAddUser;
        private System.Windows.Forms.CheckBox cbxShowPassword;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private System.Windows.Forms.CheckBox cbxActive;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPass;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.RadioButton rdoNotActive;
        private System.Windows.Forms.RadioButton rdoActive;
        private DevExpress.XtraEditors.TextEdit txtPassWord;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;



    }
}