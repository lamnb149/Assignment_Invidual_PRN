namespace SalesWinApp
{
    partial class frmProductDetails
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
            btnCancel = new Button();
            btnSave = new Button();
            txtUnitsInStock = new TextBox();
            txtProductName = new TextBox();
            label6 = new Label();
            label3 = new Label();
            txtUnitPrice = new TextBox();
            txtCategoryId = new TextBox();
            label5 = new Label();
            label2 = new Label();
            txtWeight = new TextBox();
            label4 = new Label();
            txtProductId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(318, 282);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(151, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 33;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(151, 240);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(242, 23);
            txtUnitsInStock.TabIndex = 32;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(151, 114);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(242, 23);
            txtProductName.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 248);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 21;
            label6.Text = "UnitsInStock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 83);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 22;
            label3.Text = "CategoryID";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(151, 201);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(242, 23);
            txtUnitPrice.TabIndex = 30;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(151, 75);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(242, 23);
            txtCategoryId.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 209);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 23;
            label5.Text = "UnitPrice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 167);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 24;
            label2.Text = "Weight";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(151, 159);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(242, 23);
            txtWeight.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 122);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 25;
            label4.Text = "ProductName";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(151, 33);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(242, 23);
            txtProductId.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 41);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 26;
            label1.Text = "ProductID";
            // 
            // frmProductDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 341);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtProductName);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtCategoryId);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtWeight);
            Controls.Add(label4);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            Name = "frmProductDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProductDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtUnitsInStock;
        private TextBox txtProductName;
        private Label label6;
        private Label label3;
        private TextBox txtUnitPrice;
        private TextBox txtCategoryId;
        private Label label5;
        private Label label2;
        private TextBox txtWeight;
        private Label label4;
        private TextBox txtProductId;
        private Label label1;
    }
}