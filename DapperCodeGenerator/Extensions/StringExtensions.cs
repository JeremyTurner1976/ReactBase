using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCodeGenerator.Extensions
{
    public static class StringExtensions
    {
        public static string Singularize(this string input)
        {
            return input.Substring(0, input.Length - 1);
        }
    }
}
