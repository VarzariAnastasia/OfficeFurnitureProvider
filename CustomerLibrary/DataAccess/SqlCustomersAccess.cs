using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CustomerLibrary.DataAccess
{
    public static class SqlCustomersAccess
    {
        public static string GetConnectionString(string connectionName = "CustomerDB")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadCustomerData<T>(string sql)
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

        public static int SaveCustomerData<T>(string sql, T data)
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

        public static int GetCustomerRebate(string sql, string name)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    return connection.Query<int>(sql, new { CustomerName = name }).First();                    
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
