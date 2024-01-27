namespace MyStoreWinApp
{
    partial class frmMemberManagements
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
            label1 = new Label();
            txtMemberId = new TextBox();
            dvgMemberList = new DataGridView();
            txtEmail = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            btnLoad = new Button();
            btnAdd = new Button();
            btnClose = new Button();
            txtName = new TextBox();
            label5 = new Label();
            txtCity = new TextBox();
            label6 = new Label();
            txtCountry = new TextBox();
            btnDelete = new Button();
            label2 = new Label();
            cboCity = new ComboBox();
            cboCountry = new ComboBox();
            lbFilter = new Label();
            label7 = new Label();
            label8 = new Label();
            txtSearchID = new TextBox();
            txtSearchName = new TextBox();
            btnSort = new Button();
            btnSearchName = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgMemberList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "MemberID";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(176, 38);
            txtMemberId.Margin = new Padding(4, 5, 4, 5);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(344, 31);
            txtMemberId.TabIndex = 1;
            // 
            // dvgMemberList
            // 
            dvgMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMemberList.Location = new Point(16, 378);
            dvgMemberList.Margin = new Padding(4, 5, 4, 5);
            dvgMemberList.Name = "dvgMemberList";
            dvgMemberList.ReadOnly = true;
            dvgMemberList.RowHeadersWidth = 62;
            dvgMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgMemberList.Size = new Size(1143, 352);
            dvgMemberList.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(176, 108);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(344, 31);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 122);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(176, 173);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(344, 31);
            txtPassword.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 187);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(56, 247);
            btnLoad.Margin = new Padding(4, 5, 4, 5);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(107, 38);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(230, 247);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 38);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(496, 740);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(184, 67);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(787, 38);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(344, 31);
            txtName.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(633, 122);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 0;
            label5.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(787, 108);
            txtCity.Margin = new Padding(4, 5, 4, 5);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(344, 31);
            txtCity.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(633, 187);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 0;
            label6.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(787, 173);
            txtCountry.Margin = new Padding(4, 5, 4, 5);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(344, 31);
            txtCountry.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(414, 245);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 38);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(633, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 0;
            label2.Text = "MemberName";
            // 
            // cboCity
            // 
            cboCity.FormattingEnabled = true;
            cboCity.Location = new Point(991, 245);
            cboCity.Margin = new Padding(4, 5, 4, 5);
            cboCity.Name = "cboCity";
            cboCity.Size = new Size(140, 33);
            cboCity.TabIndex = 12;
            cboCity.SelectedIndexChanged += cboCity_SelectedIndexChanged;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(787, 245);
            cboCountry.Margin = new Padding(4, 5, 4, 5);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(140, 33);
            cboCountry.TabIndex = 12;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // lbFilter
            // 
            lbFilter.AutoSize = true;
            lbFilter.Location = new Point(633, 258);
            lbFilter.Margin = new Padding(4, 0, 4, 0);
            lbFilter.Name = "lbFilter";
            lbFilter.Size = new Size(50, 25);
            lbFilter.TabIndex = 0;
            lbFilter.Text = "Filter";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 327);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 0;
            label7.Text = "Search ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(633, 327);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 0;
            label8.Text = "Search Name";
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(176, 313);
            txtSearchID.Margin = new Padding(4, 5, 4, 5);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(344, 31);
            txtSearchID.TabIndex = 6;
            txtSearchID.TextChanged += txtSearchID_TextChanged;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(787, 313);
            txtSearchName.Margin = new Padding(4, 5, 4, 5);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(253, 31);
            txtSearchName.TabIndex = 6;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(969, 740);
            btnSort.Margin = new Padding(4, 5, 4, 5);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(190, 53);
            btnSort.TabIndex = 13;
            btnSort.Text = "Sort Descending";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnSearchName
            // 
            btnSearchName.Location = new Point(1051, 312);
            btnSearchName.Margin = new Padding(4, 5, 4, 5);
            btnSearchName.Name = "btnSearchName";
            btnSearchName.Size = new Size(81, 38);
            btnSearchName.TabIndex = 14;
            btnSearchName.Text = "Search";
            btnSearchName.UseVisualStyleBackColor = true;
            btnSearchName.Click += btnSearchName_Click;
            // 
            // frmMemberManagements
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 827);
            Controls.Add(btnSearchName);
            Controls.Add(btnSort);
            Controls.Add(cboCountry);
            Controls.Add(cboCity);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(dvgMemberList);
            Controls.Add(txtSearchName);
            Controls.Add(txtSearchID);
            Controls.Add(txtCountry);
            Controls.Add(txtPassword);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lbFilter);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(txtMemberId);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMemberManagements";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberManagements";
            Load += frmMemberManagements_Load;
            ((System.ComponentModel.ISupportInitialize)dvgMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMemberId;
        private DataGridView dvgMemberList;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnClose;
        private TextBox txtName;
        private Label label5;
        private TextBox txtCity;
        private Label label6;
        private TextBox txtCountry;
        private Button btnDelete;
        private Label label2;
        private ComboBox cboCity;
        private ComboBox cboCountry;
        private Label lbFilter;
        private Label label7;
        private Label label8;
        private TextBox txtSearchID;
        private TextBox txtSearchName;
        private Button btnSort;
        private Button btnSearchName;
    }
}