using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCodeGenerator.Abstract
{
    public abstract class AbstractQuery
    {
        public string ConnectionString { get; set; }

        protected AbstractQuery()
        {
            //TODO Config Item
            ConnectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=ReactBase.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";;
        }
    }
}
