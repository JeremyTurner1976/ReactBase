using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCodeGenerator.Abstract
{
    public static class ErrorHandler
    {
        public static void HandleError(Exception ex, string message = null)
        {
            if(message != null)
                Console.WriteLine(message);

            Console.WriteLine("EXCEPTION: " + ex.Message);
            Console.WriteLine("SOURCE: " + ex.Source);
            Console.WriteLine("STACK TRACE: " + ex.StackTrace);
        }
    }
}
