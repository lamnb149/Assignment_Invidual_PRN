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
    public class OrderDAO : BaseDAL
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        public OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<OrderObject> GetOrderList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from [Order]";
            var order = new List<OrderObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    order.Add(new OrderObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
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
            return order;
        }

        public OrderObject GetOrderByID(int orderId)
        {
            OrderObject order = null;
            IDataReader dataReader = null;
            string SQLSelect = "SELECT * FROM Order WHERE OrderId = @OrderId";
            try
            {
                var param = dataProvider.CreateParameter("@OrderId", 4, orderId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    order = new OrderObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
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
            return order;
        }

        public void AddNew(OrderObject order)
        {
            try
            {
                OrderObject pro = GetOrderByID(order.OrderId);
                if (pro == null)
                {
                    string SQLInsert = "Insert Order values (@OrderId, @MemberId, @OrderDate, @RequiredDate, @ShippedDate, @Freight)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@OrderId", 4, order.OrderId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, order.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@OrderDate", 50, order.OrderDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@RequiredDate", 50, order.RequiredDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@ShippedDate", 50, order.ShippedDate, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@Freight", 50, order.Freight, DbType.Decimal));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order is already exist.");
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

        public void Remove(int orderID)
        {
            try
            {
                OrderObject car = GetOrderByID(orderID);
                if (car != null)
                {
                    string SQLDelete = "Delete Order where OrderID = @OrderID";
                    var param = dataProvider.CreateParameter("@OrderID", 4, orderID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The order does not already exist.");
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
