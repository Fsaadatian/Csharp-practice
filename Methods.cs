namespace FsaadatianMethods
{
    internal class Methods
    {
        /// <summary>
        /// To sum two intiger numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Sum(int num1 = 0, int num2 = 0)
        {
            int sum = num1 + num2;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"*** Two numbers summation is {sum}. ***");
            Console.ResetColor();
            return sum;
        }
        /// <summary>
        /// To sum three intiger numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        public static int Sum(int num1 = 0, int num2 = 0, int num3 = 0)
        {
            int sum = num1 + num2 + num3;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"***  Three numbers summation is {sum}. ***");
            Console.ResetColor();
            return sum;
        }
        /// <summary>
        /// To divide two intiger numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static void Div(int num1, int num2)
        {
            var res1 = 0;
            var res2 = 0;

            if (num1 != 0)
                 res2 = num2 % num1;
            if (num2 != 0)
                 res1 = num1 % num2;
            if (res1 == 0 || res2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("*** These two numbers are divisible. ***");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("*** These two numbers are not divisible. ***");
                Console.ResetColor();
            }
        }
        /// <summary>
        /// To define odd or even number
        /// </summary>
        /// <param name="num1"></param>
        /// <returns></returns>
        public static int OddEven(int num1)
        {
            var res = num1 % 2;
            if (res == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("*** This number is even. ***");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("*** This number is odd. ***");
                Console.ResetColor();
            }
            return res;
        }
        /// <summary>
        /// To find the minimum number of the two intiger numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static void Min(int num1, int num2)
        {

            if (num1 > num2)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"*** The minimum value is {num2}. ***");
                Console.ResetColor();

            }
            else if (num1 < num2)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"*** The minimum value is {num1}. ***");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("*** The value no. 1 is equal to The value no. 2. ***");
                Console.ResetColor();
            }

        }
        /// <summary>
        /// To find the minimum number of the five intiger numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <param name="num4"></param>
        /// <param name="num5"></param>
        public static void Min(int num1, int num2, int num3, int num4, int num5)
        {
            var min1 = 0;
            var min2 = 0;
           
            if (num1 <= num2)
                min1 = num1;
            else
                 min1 = num2;
            if (num3 <= num4)
                 min2 = num3;
            else
                 min2 = num4;
            if (min1 <= min2)
            {
                if ((min1 <= num5))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"*** The minimum value is {min1}. ***");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"*** The minimum value is {num5}. ***");
                    Console.ResetColor();
                }
            }
            else 
            {
                if ((min2 <= num5))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"*** The minimum value is {min2}. ***");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"*** The minimum value is {num5}. ***");
                    Console.ResetColor();
                }
            }


        }
        /// <summary>
        /// Fibonacci series
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Fibonacci(int num)
        {
            var num1 = 0;
            var num2 = 1;
            int sum = 0;
            if (num == 1) sum = 0;
            if (num == 2) sum = 1;
            
            for ( var i = 0; i<num-2; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"*** Fibonacci number is {sum}. ****");
            Console.ResetColor();
            return sum;
        }

        //**********************************************************************************************************
        static void Main(string[] args)
        {
            string? number, num1st, num2st;
            string? num21st, num22st, num23st, num31st, num41st, num42st;
            string? num51st, num52st, num53st, num54st, num55st;
            bool criterion = false;
            // User, enter two number to sum and divide
            do
            {
                Console.WriteLine("Please, enter two intiger numbers: ");
                num1st = Console.ReadLine();
                num2st = Console.ReadLine();
                if (string.IsNullOrEmpty(num1st) || string.IsNullOrEmpty(num2st))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please, try again. ");
                    Console.ResetColor();
                }
                else criterion = true;
            } while (criterion == false);
            int num1= int.Parse(num1st);
            int num2 = int.Parse(num2st);            
            int Sum2 = Sum(num1 , num2);
            Div(num1, num2);
            // User, enter three numbers to sum
            criterion = false;
            do
            {
                Console.WriteLine("Please, enter three intiger numbers: ");
                 num21st = Console.ReadLine();
                 num22st = Console.ReadLine();
                 num23st = Console.ReadLine();
                if (string.IsNullOrEmpty(num21st) || string.IsNullOrEmpty(num22st) || string.IsNullOrEmpty(num23st))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please, try again. ");
                    Console.ResetColor();
                }
                else criterion = true;
            } while (criterion == false);
            int num21 = int.Parse(num21st);
            int num22 = int.Parse(num22st);
            int num23 = int.Parse(num23st);
            int Sum3 = Sum(num21, num22, num23);
            // User, enter one number to define it odd or even
            criterion = false;
            do
            {
                Console.WriteLine("Please, enter an intiger numbers ");
                num31st = Console.ReadLine();
                if (string.IsNullOrEmpty(num31st))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please, try again ");
                    Console.ResetColor();
                }
                else criterion = true;
            } while (criterion == false);
            int num31 = int.Parse(num31st);
            var result = OddEven(num31);
            // User, enter two numbers to compare
            criterion = false;
            do
            {
                Console.WriteLine("Please, enter two intiger numbers: ");
                num41st = Console.ReadLine();
                num42st = Console.ReadLine();
                if (string.IsNullOrEmpty(num41st) || string.IsNullOrEmpty(num42st))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please, try again. ");
                    Console.ResetColor();
                }
                else criterion = true;
            } while (criterion == false);
            int num41 = int.Parse(num41st);
            int num42 = int.Parse(num42st);
            Min(num41, num42);
            // User, enter five numbers to compare
            criterion = false;
            do
            {
                Console.WriteLine("Please, enter five intiger numbers ");
                num51st = Console.ReadLine();
                num52st = Console.ReadLine();
                num53st = Console.ReadLine();
                num54st = Console.ReadLine();
                num55st = Console.ReadLine();
                if (string.IsNullOrEmpty(num51st) || string.IsNullOrEmpty(num52st) || string.IsNullOrEmpty(num53st) || string.IsNullOrEmpty(num54st) || string.IsNullOrEmpty(num55st))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please, try again. ");
                    Console.ResetColor();
                }
                else criterion = true;
            }while (criterion == false);
            int num51 = int.Parse(num51st);
            int num52 = int.Parse(num52st);
            int num53 = int.Parse(num53st);
            int num54 = int.Parse(num54st);
            int num55 = int.Parse(num55st);
            Min(num51, num52, num53, num54, num55);

            // To find Fibonacci number
            criterion = false;
            do
            {
                Console.WriteLine("Please, enter number of Fibonacci series ");
                number = Console.ReadLine();
                if (string.IsNullOrEmpty(number))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please, try again. ");
                    Console.ResetColor();
                }
                else criterion = true;
            } while (criterion == false);
            var num= int.Parse(number);
            result = Fibonacci(num);

        }
    }
}
