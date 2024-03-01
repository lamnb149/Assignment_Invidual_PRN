using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BaseDAL
    {
        public FStoreDataProvider dataProvider { get; set; } = null;
        public SqlConnection connection = null;
        //---------------------------------------------
        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            dataProvider = new FStoreDataProvider(connectionString);
        }
        //---------------------------------------------
        public string GetConnectionString()
        {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", true, true)
                                    .Build();
            connectionString = config["ConnectionString:FStoreDB"];
            return connectionString;
        }
        //---------------------------------------------
        public void CloseConnection() => dataProvider.CloseConnection(connection);
    } // end class
}
