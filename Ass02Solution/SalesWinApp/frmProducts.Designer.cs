namespace SalesWinApp
{
    partial class frmProducts
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
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dvgProductList = new DataGridView();
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
            label7 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dvgProductList).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(353, 459);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(129, 40);
            btnClose.TabIndex = 28;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(315, 165);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(186, 165);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(50, 165);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dvgProductList
            // 
            dvgProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProductList.Location = new Point(23, 206);
            dvgProductList.Name = "dvgProductList";
            dvgProductList.ReadOnly = true;
            dvgProductList.RowHeadersWidth = 62;
            dvgProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgProductList.Size = new Size(800, 236);
            dvgProductList.TabIndex = 19;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(562, 119);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(242, 23);
            txtUnitsInStock.TabIndex = 24;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(148, 119);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(242, 23);
            txtProductName.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 127);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 16;
            label6.Text = "UnitsInStock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 88);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 12;
            label3.Text = "CategoryID";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(562, 80);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(242, 23);
            txtUnitPrice.TabIndex = 22;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(148, 80);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(242, 23);
            txtCategoryId.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 88);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 15;
            label5.Text = "UnitPrice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 46);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 14;
            label2.Text = "Weight";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(562, 38);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(242, 23);
            txtWeight.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 127);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 13;
            label4.Text = "ProductName";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(148, 38);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(242, 23);
            txtProductId.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 46);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 17;
            label1.Text = "ProductID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(454, 173);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 16;
            label7.Text = "Search Product";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(562, 165);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(242, 23);
            txtSearch.TabIndex = 24;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 523);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dvgProductList);
            Controls.Add(txtSearch);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtProductName);
            Controls.Add(label7);
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
            Name = "frmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dvgProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dvgProductList;
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
        private Label label7;
        private TextBox txtSearch;
    }
}