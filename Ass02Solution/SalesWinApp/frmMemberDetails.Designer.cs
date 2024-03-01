namespace MyStoreWinApp
{
    partial class frmMemberDetails
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
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            label6 = new Label();
            label3 = new Label();
            txtCity = new TextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            label2 = new Label();
            txtCompanyName = new TextBox();
            label4 = new Label();
            txtMemberId = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(150, 237);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(242, 23);
            txtCountry.TabIndex = 18;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(242, 23);
            txtPassword.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 245);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 7;
            label6.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 80);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(150, 198);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(242, 23);
            txtCity.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(242, 23);
            txtEmail.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 206);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 9;
            label5.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 164);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 10;
            label2.Text = "CompanyName";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(150, 156);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(242, 23);
            txtCompanyName.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 119);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(150, 30);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(242, 23);
            txtMemberId.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 38);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 12;
            label1.Text = "MemberID";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(150, 279);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(317, 279);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 316);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
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
            Name = "frmMemberDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberDetails";
            Load += frmMemberDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCountry;
        private TextBox txtPassword;
        private Label label6;
        private Label label3;
        private TextBox txtCity;
        private TextBox txtEmail;
        private Label label5;
        private Label label2;
        private TextBox txtCompanyName;
        private Label label4;
        private TextBox txtMemberId;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
    }
}