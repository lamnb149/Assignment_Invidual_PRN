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
    public partial class frmProducts : Form
    {
        public IProductRepository productRepository { set; get; }
        public BindingSource source;
        public bool IsAdmin { set; get; }
        public MemberObject memberValue { set; get; }

        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtProductId.Enabled = false;
            if (!IsAdmin)
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                txtCategoryId.Enabled = false;
                txtProductName.Enabled = false;
                txtWeight.Enabled = false;
                txtUnitPrice.Enabled = false;
                txtUnitsInStock.Enabled = false;
            }
            IEnumerable<ProductObject> fullProduct = productRepository.GetProducts();
            LoadProductList(fullProduct.ToList());
        }

        private void LoadProductList(List<ProductObject> product)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = product;
                txtCategoryId.DataBindings.Clear();
                txtProductId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();
                txtWeight.DataBindings.Clear();

                txtCategoryId.DataBindings.Add("Text", source, "CategoryID");
                txtProductId.DataBindings.Add("Text", source, "ProductID");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");
                txtWeight.DataBindings.Add("Text", source, "Weight");

                dvgProductList.DataSource = null;
                dvgProductList.DataSource = source;

                if (product.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
                source.Position = source.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Product list");
            }
        }

        private void ClearText()
        {
            txtWeight.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductId.Text = string.Empty;
            txtCategoryId.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails()
            {
                ProductRepository = productRepository
            };
            if (frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                LoadProductList(productRepository.GetProducts().ToList());
            }
        }

        private ProductObject GetProductObject()
        {
            ProductObject product = null;
            try
            {
                product = new ProductObject()
                {
                    ProductId = int.Parse(txtProductId.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    ProductName = txtProductName.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                    Weight = txtWeight.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product");
            }
            return product;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                productRepository.UpdateProduct(product);
                MessageBox.Show($"Update Member {product.ProductId} successfully!");
                LoadProductList(productRepository.GetProducts().ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update a product");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                productRepository.DeleteProduct(product.ProductId);
                LoadProductList(productRepository.GetProducts().ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a product");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keySearch = txtSearch.Text;
            List<ProductObject> productList = new List<ProductObject>();
            foreach (var searchProduct in productRepository.GetProducts())
            {
                string combine = $@"{searchProduct.ProductId} {searchProduct.ProductName} {searchProduct.UnitPrice} {searchProduct.UnitsInStock}";
                if (combine.ToLower().Contains(keySearch.ToLower()))
                {
                    productList.Add(searchProduct);
                }
            }
            if (productList.Count >= 0)
            {
                LoadProductList(productList);
            }
            else if (keySearch == "")
            {
                LoadProductList(productRepository.GetProducts().ToList());
            }
        }
    }
}
