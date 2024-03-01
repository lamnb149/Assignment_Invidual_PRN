namespace SalesWinApp
{
    partial class frmOrders
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
            txtOrderId = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtMemberId = new TextBox();
            label3 = new Label();
            label6 = new Label();
            txtFreight = new TextBox();
            gbOrder = new GroupBox();
            btnDelete = new Button();
            dgvOrder = new DataGridView();
            dtbShippedDate = new DateTimePicker();
            dtbRequiredDate = new DateTimePicker();
            dtbOrderDate = new DateTimePicker();
            btnClose = new Button();
            gbOrderDetail = new GroupBox();
            dgvOrderDetail = new DataGridView();
            label11 = new Label();
            txtQuantity = new TextBox();
            label7 = new Label();
            txtOrderIdDetail = new TextBox();
            txtDiscount = new TextBox();
            label8 = new Label();
            txtProductId = new TextBox();
            label10 = new Label();
            txtUnitPrice = new TextBox();
            label9 = new Label();
            gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            gbOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(19, 47);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 30;
            label1.Text = "OrderID";
            // 
            // txtOrderId
            // 
            txtOrderId.Font = new Font("Segoe UI", 10F);
            txtOrderId.Location = new Point(132, 39);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(181, 25);
            txtOrderId.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(19, 128);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 26;
            label4.Text = "Freight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(369, 45);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 27;
            label2.Text = "OrderDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(369, 87);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 28;
            label5.Text = "RequiredDate";
            // 
            // txtMemberId
            // 
            txtMemberId.Font = new Font("Segoe UI", 10F);
            txtMemberId.Location = new Point(132, 81);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(181, 25);
            txtMemberId.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(19, 89);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 25;
            label3.Text = "MemberID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(369, 126);
            label6.Name = "label6";
            label6.Size = new Size(87, 19);
            label6.TabIndex = 29;
            label6.Text = "ShippedDate";
            // 
            // txtFreight
            // 
            txtFreight.Font = new Font("Segoe UI", 10F);
            txtFreight.Location = new Point(132, 120);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(181, 25);
            txtFreight.TabIndex = 35;
            // 
            // gbOrder
            // 
            gbOrder.Controls.Add(btnDelete);
            gbOrder.Controls.Add(dgvOrder);
            gbOrder.Controls.Add(dtbShippedDate);
            gbOrder.Controls.Add(dtbRequiredDate);
            gbOrder.Controls.Add(dtbOrderDate);
            gbOrder.Controls.Add(txtFreight);
            gbOrder.Controls.Add(label6);
            gbOrder.Controls.Add(label3);
            gbOrder.Controls.Add(txtMemberId);
            gbOrder.Controls.Add(label5);
            gbOrder.Controls.Add(label2);
            gbOrder.Controls.Add(label4);
            gbOrder.Controls.Add(txtOrderId);
            gbOrder.Controls.Add(label1);
            gbOrder.Font = new Font("Segoe UI", 10F);
            gbOrder.Location = new Point(22, 21);
            gbOrder.Name = "gbOrder";
            gbOrder.Size = new Size(758, 531);
            gbOrder.TabIndex = 0;
            gbOrder.TabStop = false;
            gbOrder.Text = "Order";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.Location = new Point(639, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 27);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(19, 196);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new Size(719, 321);
            dgvOrder.TabIndex = 37;
            dgvOrder.DoubleClick += dgvOrder_DoubleClick;
            // 
            // dtbShippedDate
            // 
            dtbShippedDate.Font = new Font("Segoe UI", 10F);
            dtbShippedDate.Format = DateTimePickerFormat.Custom;
            dtbShippedDate.Location = new Point(486, 120);
            dtbShippedDate.Name = "dtbShippedDate";
            dtbShippedDate.Size = new Size(252, 25);
            dtbShippedDate.TabIndex = 36;
            // 
            // dtbRequiredDate
            // 
            dtbRequiredDate.Font = new Font("Segoe UI", 10F);
            dtbRequiredDate.Format = DateTimePickerFormat.Custom;
            dtbRequiredDate.Location = new Point(486, 81);
            dtbRequiredDate.Name = "dtbRequiredDate";
            dtbRequiredDate.Size = new Size(252, 25);
            dtbRequiredDate.TabIndex = 36;
            // 
            // dtbOrderDate
            // 
            dtbOrderDate.Font = new Font("Segoe UI", 10F);
            dtbOrderDate.Format = DateTimePickerFormat.Custom;
            dtbOrderDate.Location = new Point(486, 41);
            dtbOrderDate.MaxDate = new DateTime(9000, 3, 1, 0, 0, 0, 0);
            dtbOrderDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtbOrderDate.Name = "dtbOrderDate";
            dtbOrderDate.Size = new Size(252, 25);
            dtbOrderDate.TabIndex = 36;
            dtbOrderDate.Value = new DateTime(2024, 3, 1, 0, 0, 0, 0);
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Location = new Point(717, 567);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(141, 44);
            btnClose.TabIndex = 39;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // gbOrderDetail
            // 
            gbOrderDetail.Controls.Add(dgvOrderDetail);
            gbOrderDetail.Controls.Add(label11);
            gbOrderDetail.Controls.Add(txtQuantity);
            gbOrderDetail.Controls.Add(label7);
            gbOrderDetail.Controls.Add(txtOrderIdDetail);
            gbOrderDetail.Controls.Add(txtDiscount);
            gbOrderDetail.Controls.Add(label8);
            gbOrderDetail.Controls.Add(txtProductId);
            gbOrderDetail.Controls.Add(label10);
            gbOrderDetail.Controls.Add(txtUnitPrice);
            gbOrderDetail.Controls.Add(label9);
            gbOrderDetail.Font = new Font("Segoe UI", 10F);
            gbOrderDetail.Location = new Point(799, 21);
            gbOrderDetail.Name = "gbOrderDetail";
            gbOrderDetail.Size = new Size(715, 531);
            gbOrderDetail.TabIndex = 1;
            gbOrderDetail.TabStop = false;
            gbOrderDetail.Text = "OrderDetail";
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(20, 196);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.ReadOnly = true;
            dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetail.Size = new Size(679, 321);
            dgvOrderDetail.TabIndex = 37;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(405, 47);
            label11.Name = "label11";
            label11.Size = new Size(63, 19);
            label11.TabIndex = 30;
            label11.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 10F);
            txtQuantity.Location = new Point(518, 39);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(181, 25);
            txtQuantity.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(20, 45);
            label7.Name = "label7";
            label7.Size = new Size(59, 19);
            label7.TabIndex = 30;
            label7.Text = "OrderID";
            // 
            // txtOrderIdDetail
            // 
            txtOrderIdDetail.Font = new Font("Segoe UI", 10F);
            txtOrderIdDetail.Location = new Point(133, 37);
            txtOrderIdDetail.Name = "txtOrderIdDetail";
            txtOrderIdDetail.Size = new Size(181, 25);
            txtOrderIdDetail.TabIndex = 31;
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 10F);
            txtDiscount.Location = new Point(518, 81);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(181, 25);
            txtDiscount.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(20, 126);
            label8.Name = "label8";
            label8.Size = new Size(64, 19);
            label8.TabIndex = 26;
            label8.Text = "UnitPrice";
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Segoe UI", 10F);
            txtProductId.Location = new Point(133, 79);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(181, 25);
            txtProductId.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(405, 89);
            label10.Name = "label10";
            label10.Size = new Size(63, 19);
            label10.TabIndex = 25;
            label10.Text = "Discount";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Segoe UI", 10F);
            txtUnitPrice.Location = new Point(133, 118);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(181, 25);
            txtUnitPrice.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(20, 87);
            label9.Name = "label9";
            label9.Size = new Size(71, 19);
            label9.TabIndex = 25;
            label9.Text = "ProductID";
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 621);
            Controls.Add(gbOrderDetail);
            Controls.Add(btnClose);
            Controls.Add(gbOrder);
            Name = "frmOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOrders";
            Load += frmOrders_Load;
            gbOrder.ResumeLayout(false);
            gbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            gbOrderDetail.ResumeLayout(false);
            gbOrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtOrderId;
        private Label label4;
        private Label label2;
        private Label label5;
        private TextBox txtMemberId;
        private Label label3;
        private Label label6;
        private TextBox txtFreight;
        private GroupBox gbOrder;
        private DateTimePicker dtbOrderDate;
        private Button btnDelete;
        private Button btnClose;
        private DataGridView dgvOrder;
        private DateTimePicker dtbShippedDate;
        private DateTimePicker dtbRequiredDate;
        private GroupBox gbOrderDetail;
        private DataGridView dgvOrderDetail;
        private Label label11;
        private TextBox txtQuantity;
        private Label label7;
        private TextBox txtOrderIdDetail;
        private TextBox txtDiscount;
        private Label label8;
        private TextBox txtProductId;
        private Label label10;
        private TextBox txtUnitPrice;
        private Label label9;
    }
}