using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


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
       
    }
}
