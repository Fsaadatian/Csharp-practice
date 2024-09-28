namespace Fsaadatian_Practice
    // The aim of this program is to receive a user's profile, including first and last name, age and mobile number, and then print them.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, Enter your profile");
            Console.WriteLine("First Name: ");
            String? First_Name = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            String? Last_Name = Console.ReadLine();
            Console.WriteLine("Age: ");
            String? Age = Console.ReadLine();
            Console.WriteLine("Mobile Number: ");
            String? Mobile_Number = Console.ReadLine();
            if (String.IsNullOrEmpty(First_Name) || String.IsNullOrEmpty(Last_Name) || String.IsNullOrEmpty(Age) || String.IsNullOrEmpty(Mobile_Number))
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("Please, complete the deficiencies and then run the program again.");
            }
            else
            {
                Console.WriteLine("*******************************************************************************************************************************");
                Console.WriteLine("Thank you, You are Mr./Mrs." + First_Name + " " + Last_Name + ", " + Age + " years old and your mobile number is " + Mobile_Number + ".");
                Console.WriteLine("*******************************************************************************************************************************");
            }

        }
    }
}
