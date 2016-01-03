using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperCodeGenerator.Abstract;
using DapperCodeGenerator.SqlQueries;

namespace DapperCodeGenerator.Services
{
    public class DataProjectCodeGenerator : AbstractCodeGenerator
    {
        private const string TableModelsLocation = @"..\..\..\src\ReactBase.Data\TableModels";

        public void GenerateDataProjectCode()
        {
            var databaseQueries = new DatabaseQueries();
            var fileHandler = new FileHandler();

            var classSet = databaseQueries.GetDatabaseClasses();
            foreach (var item in classSet)
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine(StartMessage);
                stringBuilder.AppendLine("using System;");
                stringBuilder.AppendLine("using ReactBase.Data.Abstract;");
                stringBuilder.AppendLine("namespace ReactBase.Data.TableModels{");
                foreach (var fileLine in item.Value)
                {
                    stringBuilder.AppendLine(fileLine);
                }
                stringBuilder.AppendLine("}");
                fileHandler.GenerateNewFile(TableModelsLocation, item.Key, "cs", stringBuilder.ToString());
            }
        }
    }
}
