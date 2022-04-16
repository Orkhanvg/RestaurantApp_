using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helper
{
    public static class Extention
    {
        public static void ShowMe(ConsoleColor color , string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to our Restaurant");
            Console.ResetColor();
        }
    }
}
