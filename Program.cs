using System.Reflection.Metadata.Ecma335;

namespace FsaadatianPractice
    // The aim of this program is to receive a user's profile, including first and last name, age and mobile number, and then print them.
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string firstName, lastName, ageSt, mobileNumberSt;
            Console.Title = "F. Saadatian Practice";
            Console.WriteLine("Please, enter your profile");
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++ To receipt user first name ++++++++++++++++++++++++++++++++++++++++++++
            bool criterionFirst = false;
            do
            {
                Console.WriteLine("First name: ");
                firstName = Console.ReadLine() ?? "";
                if (String.IsNullOrEmpty(firstName))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please, try again and enter your first name correctly.");
                    Console.ResetColor();
                }
                else
                {
                    char[] arrayfirstName = firstName.ToCharArray();
                    for (int count = 0; count < firstName.Length; count++)
                    {
                        if (char.IsDigit(arrayfirstName[count]))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Please, try again and enter your first name correctly.");
                            Console.ResetColor();
                            criterionFirst = false;
                            break;
                        }
                        else
                            criterionFirst = true;
                    }
                }
            } while (criterionFirst == false);
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++ To receipt user last name ++++++++++++++++++++++++++++++++++++++++++++
            bool criterionSecond = false;
            do
            {
                Console.WriteLine("Last name: ");
                lastName = Console.ReadLine() ?? "";
                if (String.IsNullOrEmpty(lastName))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please, enter your last name correctly and then try again.");
                    Console.ResetColor();
                }
                else
                {
                    char[] arraylastName = lastName.ToCharArray();
                    for (int count = 0; count < lastName.Length; count++)
                    {
                        if (char.IsDigit(arraylastName[count]))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Please, enter your last name correctly and then try again.");
                            Console.ResetColor();
                            criterionSecond = false;
                            break;
                        }
                        else criterionSecond = true;
                    }
                }
            } while (criterionSecond==false);
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++ To receipt user age ++++++++++++++++++++++++++++++++++++++++++++
            bool criterionThird = false;
            do
            {
                Console.WriteLine("Age: ");
                ageSt = Console.ReadLine() ?? "";
                if (String.IsNullOrEmpty(ageSt))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please, try again and enter your age correctly.");
                    Console.ResetColor();
                }
                else
                {
                    try
                    {
                        int Age = int.Parse(ageSt);
                        if (Age < 15 || Age > 120)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Sorry, you are not valid to register.");
                            Console.ResetColor();
                            return;
                        }
                        else criterionThird = true;
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Please, try again and enter your age correctly.");
                        Console.ResetColor();
                    }
                }
            } while (criterionThird==false);
            // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++ To receipt user mobile number ++++++++++++++++++++++++++++++++++++++++++++
            bool criterionfourth=false;
            do
            {
                Console.WriteLine("Mobile number: ");
                mobileNumberSt = Console.ReadLine() ?? "";
                mobileNumberSt = mobileNumberSt.Trim().Replace("+98", "0");
                if (mobileNumberSt.Length == 11 && mobileNumberSt.StartsWith("0"))
                {
                    try
                    {
                        long mobileNumberLong = long.Parse(mobileNumberSt);
                        criterionfourth = true;
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Sorry, your mobile number is not valid. Please, try again.");
                        Console.ResetColor();
                    }

                }
                else if (mobileNumberSt.Length == 10 && !mobileNumberSt.StartsWith("0"))
                {
                    mobileNumberSt = $"0{mobileNumberSt}";
                    try
                    {
                        long mobileNumberLong = long.Parse(mobileNumberSt);
                        criterionfourth = true;
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Sorry, your mobile number is not valid. Please, try again.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Sorry, your mobile number is not valid. Please, try again.");
                    Console.ResetColor();
                }
            } while (criterionfourth == false);

            Console.Clear();
            Console.SetCursorPosition(0, 5);
            Console.ForegroundColor=ConsoleColor.DarkCyan;
            Console.WriteLine("********************************************************************************************************************");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Thanks, You are Mr./Mrs. {firstName} {lastName}, {ageSt} years old and your mobile number is {mobileNumberSt}.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("********************************************************************************************************************");
            Console.ResetColor();
        }
    }
}
