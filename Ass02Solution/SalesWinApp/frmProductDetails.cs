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
    public partial class frmProductDetails : Form
    {
        public IProductRepository ProductRepository { get; set; }
        public frmProductDetails()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new ProductObject()
                {
                    ProductId = int.Parse(txtProductId.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    ProductName = txtProductName.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                    Weight = txtWeight.Text,
                };
                ProductRepository.InsertProduct(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add a new product");
            }
        }
    }
}
