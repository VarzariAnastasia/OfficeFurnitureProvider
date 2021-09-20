using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary.DataAccess
{
    public class SqlProductsAccess
    {
        public static string GetConnectionString(string connectionName = "ProductDB")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadProductData<T>(string sql)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {                
                try
                {
                    return connection.Query<T>(sql).ToList();
                }
                catch (Exception)
                {
                    //could not koad the data - handle exception
                    return new List<T>();
                }
            }
        }

        public static int SaveProductData<T>(string sql, T data)
        {

            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {                
                try
                {
                    return connection.Execute(sql, data);
                }
                catch (Exception)
                {
                    //could not save the data - handle exception
                    return 0;
                }
            }
        }

        public static int GetProductPrice(string sql, string name)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    return connection.Query<int>(sql, new { ProductName = name }).First();
                }
                catch (Exception)
                {
                    //could not koad the data - handle exception
                    return 0;
                }
            }
        }

        public static int GetProductQuantity(string sql, string name)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    return connection.Query<int>(sql, new { ProductName = name }).First();
                }
                catch (Exception)
                {
                    //could not koad the data - handle exception
                    return 0;
                }
            }
        }
    }
}
