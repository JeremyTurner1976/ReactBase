using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DapperCodeGenerator.Abstract;

namespace DapperCodeGenerator.SqlQueries
{
    internal class DatabaseQueries : AbstractQuery
    {
        private const string GetTableNamesProc = "Helper_GetDatabaseTableNames";
        private const string GetTableClassesProc = "Helper_CreatePocoFromTableName";

        public Dictionary<string, List<string>> GetDatabaseClasses()
        {
            var returnDictionary = new Dictionary<string, List<string>>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    var tableNameList = connection.Query<string>(GetTableNamesProc, commandType: CommandType.StoredProcedure).ToList();
                    foreach (var item in tableNameList)
                    {
                        var dynamicParameters = new DynamicParameters();
                        dynamicParameters.Add("tableName", item);
                        returnDictionary.Add(item, connection.Query<string>(GetTableClassesProc, dynamicParameters, commandType: CommandType.StoredProcedure).ToList());
                    }

                }
                catch (Exception ex)
                {

                }
            }

            return returnDictionary;
        }
    }
}
