


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ReactBase.Data.TableModels;
using Dapper;

namespace ReactBase.Data
{
    public class Repository
    {
        public string ConnectionString { get; set; }

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
                    errors = connection.Query<Error>("Select * from dbo.Errors").ToList();
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
