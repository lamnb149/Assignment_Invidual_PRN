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
            txtName = new TextBox();
            label4 = new Label();
            txtMemberId = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(214, 395);
            txtCountry.Margin = new Padding(4, 5, 4, 5);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(344, 31);
            txtCountry.TabIndex = 18;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(214, 185);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(344, 31);
            txtPassword.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 408);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 7;
            label6.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 133);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(214, 330);
            txtCity.Margin = new Padding(4, 5, 4, 5);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(344, 31);
            txtCity.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(214, 120);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(344, 31);
            txtEmail.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 343);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 9;
            label5.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 273);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 10;
            label2.Text = "MemberName";
            // 
            // txtName
            // 
            txtName.Location = new Point(214, 260);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(344, 31);
            txtName.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 198);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(214, 50);
            txtMemberId.Margin = new Padding(4, 5, 4, 5);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(344, 31);
            txtMemberId.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 12;
            label1.Text = "MemberID";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(214, 465);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 38);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(453, 465);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 38);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 527);
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
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(txtMemberId);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
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
        private TextBox txtName;
        private Label label4;
        private TextBox txtMemberId;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
    }
}