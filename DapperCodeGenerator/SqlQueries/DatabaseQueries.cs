using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DapperCodeGenerator.Abstract;
using DapperCodeGenerator.Extensions;

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
                    foreach (var tableName in tableNameList)
                    {
                        var singularTableName = tableName.Singularize();
                        var dynamicParameters = new DynamicParameters();
                        dynamicParameters.Add("tableName", tableName);
                        dynamicParameters.Add("singularTableName", singularTableName);
                        returnDictionary.Add(tableName, connection.Query<string>(GetTableClassesProc, dynamicParameters, commandType: CommandType.StoredProcedure).ToList());
                    }

                }
                catch (Exception)
                {
                    connection.Close();
                    throw;
                }
            }

            return returnDictionary;
        }
    }
}
