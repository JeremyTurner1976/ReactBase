using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperCodeGenerator.Abstract;
using DapperCodeGenerator.Services;
using DapperCodeGenerator.SqlQueries;

namespace DapperCodeGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Todo programmable sections (Data, Web, ClientSide, UnitTests)

            try
            {
                var dataProjectCodeGen = new DataProjectCodeGenerator();
                dataProjectCodeGen.GenerateDataProjectCode();
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex);
            }

            //TODO Pause for button push
        }
    }
}
