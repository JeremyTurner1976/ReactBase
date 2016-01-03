using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperCodeGenerator.Services;
using DapperCodeGenerator.SqlQueries;

namespace DapperCodeGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Todo programmable sections (Data, Web, ClientSide, UnitTests)

            var dataProjectCodeGen = new DataProjectCodeGenerator();
            dataProjectCodeGen.GenerateDataProjectCode();

            //TODO Pause for button push
        }
    }
}
