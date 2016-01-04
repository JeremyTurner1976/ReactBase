


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ReactBase.Data.TableModels;
using Dapper;
using Dapper.Contrib.Extensions;

namespace ReactBase.Data
{
    public class Repository
    {
        public string ConnectionString { get; set; }

        /*Dapper Contrib Extensions*/
        //T Get<T>(id);
        //IEnumerable<T> GetAll<T>();
        //int Insert<T>(T obj);
        //int Insert<T>(IEnumerable<T> list);
        //bool Update<T>(T obj);
        //bool Update<T>(IEnumerable<T> list);
        //bool Delete<T>(T obj);
        //bool Delete<T>(IEnumerable<T> list);
        //bool DeleteAll<T>();


        public Repository()
        {
            //TODO Config Item
            ConnectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=ReactBase.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; ;
        }

        public string Ping()
        {
            return "Pong";
        }

        public List<Error> GetAllErrors()
        {
            List<Error> errors;
            using (var connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    errors = connection.GetAll<Error>().ToList();
                }
                catch (Exception)
                {
                    connection.Close();
                    throw;
                }
            }
            return errors;
        }


    }
}
