using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FsaadatianPractice.Models
{
    internal class User
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string MobileNumberSt { get; set; }
        public string AgeSt { get; set; }

public string ShowDetail()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 5);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("********************************************************************************************************************");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Your Detail: You are Mr./Mrs. {FirstName} {LastName}, {AgeSt} years old and your mobile number is {MobileNumberSt}.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*********************************************************************************************************************");
            Console.ResetColor();
            return "";
        }

    }
}
