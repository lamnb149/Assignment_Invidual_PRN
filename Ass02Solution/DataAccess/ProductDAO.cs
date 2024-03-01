using BusinessObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO : BaseDAL
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        public ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<ProductObject> GetProductList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Product";
            var products = new List<ProductObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return products;
        }

        public ProductObject GetProductByID(int productID)
        {
            ProductObject pro = null;
            IDataReader dataReader = null;
            string SQLSelect = "SELECT * FROM Product WHERE ProductID = @ProductID";
            try
            {
                var param = dataProvider.CreateParameter("@ProductID", 4, productID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    pro = new ProductObject
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return pro;
        }

        public void AddNew(ProductObject product)
        {
            try
            {
                ProductObject pro = GetProductByID(product.ProductId);
                if (pro == null)
                {
                    string SQLInsert = "Insert Product values (@ProductID, @CategoryID, @ProductName, @Weight, @UnitPrice, @UnitsInStock)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductID", 4, product.ProductId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryID", 4, product.CategoryId, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 50, product.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 50, product.Weight, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 8, product.UnitPrice, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitsInStock", 4, product.UnitsInStock, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The product is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(ProductObject product)
        {
            try
            {
                ProductObject c = GetProductByID(product.ProductId);
                if (c != null)
                {
                    string SQLUpdate = "Update Product set CategoryID = @CategoryID, ProductName = @ProductName, " +
                                       "Weight = @Weight, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock where ProductID = @ProductID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductID", 4, product.ProductId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryID", 4, product.CategoryId, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 50, product.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 50, product.Weight, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 8, product.UnitPrice, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitsInStock", 4, product.UnitsInStock, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The product does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int productId)
        {
            try
            {
                ProductObject car = GetProductByID(productId);
                if (car != null)
                {
                    string SQLDelete = "Delete Product where ProductID = @ProductID";
                    var param = dataProvider.CreateParameter("@ProductID", 4, productId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The product does not already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
