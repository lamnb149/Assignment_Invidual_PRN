namespace MyStoreWinApp
{
    partial class frmMembers
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
            btnAdd = new Button();
            btnClose = new Button();
            txtCompanyName = new TextBox();
            label5 = new Label();
            txtCity = new TextBox();
            label6 = new Label();
            txtCountry = new TextBox();
            btnDelete = new Button();
            label2 = new Label();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgMemberList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 31);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "MemberID";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(123, 23);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(242, 23);
            txtMemberId.TabIndex = 1;
            // 
            // dvgMemberList
            // 
            dvgMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMemberList.Location = new Point(12, 191);
            dvgMemberList.Name = "dvgMemberList";
            dvgMemberList.ReadOnly = true;
            dvgMemberList.RowHeadersWidth = 62;
            dvgMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgMemberList.Size = new Size(800, 236);
            dvgMemberList.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(123, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(242, 23);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 73);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(123, 104);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(242, 23);
            txtPassword.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 112);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(233, 150);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(342, 444);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(129, 40);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(551, 23);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(242, 23);
            txtCompanyName.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(443, 73);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 0;
            label5.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(551, 65);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(242, 23);
            txtCity.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(443, 112);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 0;
            label6.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(551, 104);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(242, 23);
            txtCountry.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(508, 150);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 31);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 0;
            label2.Text = "CompanyName";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(373, 150);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 496);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dvgMemberList);
            Controls.Add(txtCountry);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtCompanyName);
            Controls.Add(label4);
            Controls.Add(txtMemberId);
            Controls.Add(label1);
            Name = "frmMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberManagements";
            Load += frmMembers_Load;
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
        private Button btnAdd;
        private Button btnClose;
        private TextBox txtCompanyName;
        private Label label5;
        private TextBox txtCity;
        private Label label6;
        private TextBox txtCountry;
        private Button btnDelete;
        private Label label2;
        private Button btnUpdate;
    }
}