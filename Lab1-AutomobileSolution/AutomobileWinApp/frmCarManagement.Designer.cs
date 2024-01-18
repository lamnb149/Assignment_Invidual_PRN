namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            lbManufacturer = new Label();
            lbCarName = new Label();
            lbReleaseYear = new Label();
            lbPrice = new Label();
            txtCarID = new TextBox();
            btnDelete = new Button();
            btnLoad = new Button();
            btnNew = new Button();
            dgvCarList = new DataGridView();
            txtCarName = new TextBox();
            txtManufacturer = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(21, 43);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(39, 15);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(22, 132);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 0;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(21, 90);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 0;
            lbCarName.Text = "Car Name";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(372, 90);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(78, 15);
            lbReleaseYear.TabIndex = 0;
            lbReleaseYear.Text = "Released Year";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(372, 43);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 0;
            lbPrice.Text = "Price";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(121, 35);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(190, 23);
            txtCarID.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(508, 169);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(121, 169);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(312, 169);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(12, 198);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(688, 194);
            dgvCarList.TabIndex = 3;
            dgvCarList.CellDoubleClick += dgvCarList_CellDoubleClick;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(121, 82);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(190, 23);
            txtCarName.TabIndex = 1;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(121, 124);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(190, 23);
            txtManufacturer.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(474, 35);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(190, 23);
            txtPrice.TabIndex = 3;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(474, 82);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(190, 23);
            txtReleaseYear.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(312, 401);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 436);
            Controls.Add(dgvCarList);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbCarName);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private Label lbManufacturer;
        private Label lbCarName;
        private Label lbReleaseYear;
        private Label lbPrice;
        private TextBox txtCarID;
        private Button btnDelete;
        private Button btnLoad;
        private Button btnNew;
        private DataGridView dgvCarList;
        private TextBox txtCarName;
        private TextBox txtManufacturer;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
        private Button btnClose;
    }
}