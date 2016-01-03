using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperCodeGenerator.Abstract;

namespace DapperCodeGenerator.Services
{
    public class FileHandler// TODO Extract interface : IFileHandle
    {
        public void GenerateNewFile(string path, string fileName, string fileExtension, string content)
        {
            var fullyQualifiedPath = GetFullPath(path, fileName, fileExtension);
            File.WriteAllText(fullyQualifiedPath, content);
            Console.WriteLine(fileName + "." + fileExtension + " Created.");
        }

        private string GetFullPath(string path, string fileName, string fileExtension)
        {
            return Path.Combine(path, fileName + "." + fileExtension);
        }
    }
}
