using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCodeGenerator.Services
{
    public class FileHandler// TODO Extract interface : IFileHandle
    {
        public bool GenerateNewFile(string path, string fileName, string fileExtension, string content)
        {
            try
            {
                var fullyQualifiedPath = GetFullPath(path, fileName, fileExtension);
                File.WriteAllText(fullyQualifiedPath, content);
                Console.WriteLine(fileName + "." + fileExtension + " Created.");
                return true;
            }
            catch (Exception ex)
            {
                //TODO Enhance outputs and stop execution
                Console.WriteLine(fileName + "." + fileExtension + " EXCEPTION: " + ex.Message);
                Console.WriteLine("SOURCE: " + ex.Source);
                Console.WriteLine("STACK TRACE: " + ex.StackTrace);
                return false;
            }
        }

        private string GetFullPath(string path, string fileName, string fileExtension)
        {
            return Path.Combine(path, fileName + "." + fileExtension);
        }
    }
}
