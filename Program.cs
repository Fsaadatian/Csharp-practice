﻿using System.Reflection.Metadata.Ecma335;

namespace Fsaadatian_Practice
    // The aim of this program is to receive a user's profile, including first and last name, age and mobile number, and then print them.
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your profile");
            Console.WriteLine("First name: ");
            String? FirstName = Console.ReadLine();
            if (String.IsNullOrEmpty(FirstName))
            {
                Console.WriteLine("Please, enter your first name correctly and then try again.");
                return;
            }
            char[] ArrayFirstName = FirstName.ToCharArray();
            for (int count=0; count < FirstName.Length; count++)
            {
                    if (char.IsDigit(ArrayFirstName[count]))
                    {
                        Console.WriteLine("Please, enter your first name correctly and then try again.");
                        return;
                    }
            }
            Console.WriteLine("Last name: ");
            String? LastName = Console.ReadLine();
            if (String.IsNullOrEmpty(LastName))
            {
                Console.WriteLine("Please, enter your last name correctly and then try again.");
                return;
            }
            char[] ArrayLastName = LastName.ToCharArray();
            for (int count = 0; count < LastName.Length; count++)
            {
                if (char.IsDigit(ArrayLastName[count]))
                {
                    Console.WriteLine("Please, enter your last name correctly and then try again.");
                    return;
                }
            }

            Console.WriteLine("Age: ");
            String? AgeSt = Console.ReadLine();
            if (String.IsNullOrEmpty(AgeSt))
            {
                Console.WriteLine("Please, enter your age correctly and then try again.");
                return;
            }
            try
            {
                int Age = int.Parse(AgeSt);
                if (Age < 15 || Age > 120)
                {
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("Sorry, you are not valid to register.");
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    return;
                }

            }
            catch
            {
                Console.WriteLine("Please, enter your age correctly and then try again.");
                return;
            }
            
            Console.WriteLine("Mobile number: ");
            String MobileNumberSt = Console.ReadLine() ?? "";
            MobileNumberSt = MobileNumberSt.Trim().Replace("+98", "0");
            if (MobileNumberSt.Length == 11 && MobileNumberSt.StartsWith("0"))
            {
                try
                {
                    long MobileNumberLong = long.Parse(MobileNumberSt);
                }
                catch 
                {
                    Console.WriteLine("Sorry, your mobile number is not valid. Please, try again.");
                    return;
                }

            }
            else if (MobileNumberSt.Length == 10 && !MobileNumberSt.StartsWith("0"))
            {
                MobileNumberSt = $"0{MobileNumberSt}";
                try
                {
                    long MobileNumberLong = long.Parse(MobileNumberSt);
                }
                catch
                {
                    Console.WriteLine("Sorry, your mobile number is not valid. Please, try again.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, your mobile number is not valid. Please, try again.");
                return;
            }
            
            
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine($"Thank you, You are Mr./Mrs. {FirstName} {LastName}, {AgeSt} years old and your mobile number is {MobileNumberSt}.");
            Console.WriteLine("**************************************************************************************************************");
        }
    }
}
