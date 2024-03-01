using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        public IOrderRepository OrderRepository { get; set; }
        public IOrderDetailRepository OrderDetailRepository { get; set; }
        public bool IsAdmin { get; set; }
        public MemberObject MemberValue { get; set; }
        public BindingSource sourceOrder;
        public BindingSource sourceOrderDetail;

        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            txtOrderId.Enabled = false;
            txtMemberId.Enabled = false;
            txtOrderIdDetail.Enabled = false;
            if (!IsAdmin)
            {
                btnDelete.Visible = false;
                txtFreight.Enabled = false;
            }
            LoadOrderList(OrderRepository.GetOrders().ToList());
        }

        private void LoadOrderList(List<OrderObject> order)
        {
            try
            {
                sourceOrder = new BindingSource();
                if (IsAdmin)
                {
                    sourceOrder.DataSource = order;
                }
                else
                {
                    List<OrderObject> orders = new List<OrderObject>();
                    foreach (OrderObject o in order)
                    {
                        if (o.MemberId == MemberValue.MemberId)
                        {
                            orders.Add(o);
                        }
                    }
                    sourceOrder.DataSource = orders;
                }
                txtOrderId.DataBindings.Clear();
                txtMemberId.DataBindings.Clear();
                txtFreight.DataBindings.Clear();
                dtbOrderDate.DataBindings.Clear();
                dtbRequiredDate.DataBindings.Clear();
                dtbShippedDate.DataBindings.Clear();

                txtOrderId.DataBindings.Add("Text", sourceOrder, "OrderId");
                txtMemberId.DataBindings.Add("Text", sourceOrder, "MemberId");
                txtFreight.DataBindings.Add("Text", sourceOrder, "Freight");
                dtbOrderDate.DataBindings.Add("Text", sourceOrder, "OrderDate");
                dtbRequiredDate.DataBindings.Add("Text", sourceOrder, "RequiredDate");
                dtbShippedDate.DataBindings.Add("Text", sourceOrder, "ShippedDate");

                dgvOrder.DataSource = null;
                dgvOrder.DataSource = sourceOrder;

                if (order.Count() == 0)
                {
                    ClearTextGbOrder();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
                sourceOrder.Position = sourceOrder.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order list");
            }
        }

        private void ClearTextGbOrder()
        {
            txtOrderId.Text = string.Empty;
            txtMemberId.Text = string.Empty;
            txtFreight.Text = string.Empty;
            dtbShippedDate.Text = string.Empty;
            dtbRequiredDate.Text = string.Empty;
            dtbOrderDate.Text = string.Empty;
        } // End

        private OrderObject GetOrderObject()
        {
            OrderObject order = null;
            try
            {
                order = new OrderObject()
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    MemberId = int.Parse(txtMemberId.Text),
                    OrderDate = DateTime.Parse(dtbOrderDate.Text),
                    RequiredDate = DateTime.Parse(dtbRequiredDate.Text),
                    ShippedDate = DateTime.Parse(dtbShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");
            }
            return order;
        }

        private void dgvOrder_DoubleClick(object sender, EventArgs e)
        {
            //if (dgvOrder.CurrentRow == null || dgvOrder.CurrentRow.IsNewRow) return;
            //List<OrderDetailObject> orderDetailList = new List<OrderDetailObject>();
            //foreach (var orderDetail in OrderDetailRepository.GetOrderDetail())
            //{
            //    if (orderDetail.OrderId == int.Parse(txtOrderId.Text))
            //    {
            //        orderDetailList.Add(orderDetail);
            //    }
            //}
            //LoadOrderDetailList(orderDetailList);
        }

        //private void LoadOrderDetailList(List<OrderDetailObject> orderDetail)
        //{
        //    try
        //    {
        //        sourceOrderDetail = new BindingSource();
        //        sourceOrderDetail.DataSource = orderDetail;

        //        txtOrderIdDetail.DataBindings.Clear();
        //        txtProductId.DataBindings.Clear();
        //        txtUnitPrice.DataBindings.Clear();
        //        txtQuantity.DataBindings.Clear();
        //        txtDiscount.DataBindings.Clear();

        //        txtOrderIdDetail.DataBindings.Add("Text", sourceOrderDetail, "OrderId");
        //        txtProductId.DataBindings.Add("Text", sourceOrderDetail, "ProductId");
        //        txtUnitPrice.DataBindings.Add("Text", sourceOrderDetail, "UnitPrice");
        //        txtQuantity.DataBindings.Add("Text", sourceOrderDetail, "Quantity");
        //        txtDiscount.DataBindings.Add("Text", sourceOrderDetail, "Discount");

        //        dgvOrderDetail.DataSource = null;
        //        dgvOrderDetail.DataSource = sourceOrderDetail;

        //        sourceOrderDetail.Position = sourceOrderDetail.Count - 1;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Load Order Detail list");
        //    }
        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
