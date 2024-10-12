namespace Fsaadatian_methods
{
    internal class Methods
    {
        /// <summary>
        /// To sum two intiger numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Sum(int num1, int num2)
        {
            int Sum = num1 + num2;
            Console.WriteLine($"*** Summation two numbers is {Sum}. ***");
            return Sum;
        }
        /// <summary>
        /// To sum three intiger numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        public static int Sum(int num1, int num2, int num3)
        {
            int Sum = num1 + num2 + num3;
            Console.WriteLine($"*** Summation two numbers is {Sum}. ***");
            return Sum;
        }
        /// <summary>
        /// To divide two intiger numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static void Div(int num1, int num2)
        {
            var Res1 = num1 % num2;
            var Res2 = num2 % num1;
            if (Res1 == 0 || Res2 == 0)
            {
                Console.WriteLine("*** These two numbers are divisible. ***");
            }
            else
            {
                Console.WriteLine("*** These two numbers are not divisible. ***");
            }
        }
        /// <summary>
        /// To define odd or even number
        /// </summary>
        /// <param name="num1"></param>
        /// <returns></returns>
        public static int OddEven(int num1)
        {
            var Res = num1 % 2;
            if (Res == 0)
            {
                Console.WriteLine("*** This number is even. ***");
            }
            else
            {
                Console.WriteLine("*** This number is odd. ***");
            }
            return Res;
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
                Console.WriteLine($"*** The minimum value is {num2}. ***");

            }
            else if (num1 < num2)
            {
                Console.WriteLine($"*** The minimum value is {num1}. ***");
            }
            else
            {
                Console.WriteLine("*** The value no. 1 is equal to The value no. 2. ***");
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
            {
                min1 = num1;
            }
            else 
            {
                 min1 = num2;
            }
            if (num3 <= num4)
            {
                 min2 = num3;
            }
            else
            {
                 min2 = num4;
            }
            if ((min1 <= min2))
            {
                if ((min1 <= num5))
                { 
                Console.WriteLine($"*** The minimum value is {min1}. ***");
                }
                else
                {
                    Console.WriteLine($"*** The minimum value is {num5}. ***");
                }
            }
            else 
            {
                if ((min2 <= num5))
                {
                    Console.WriteLine($"*** The minimum value is {min2}. ***");
                }
                else
                {
                    Console.WriteLine($"*** The minimum value is {num5}. ***");
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
            var sum = 0;
            
            for ( var i = 0; i<num-2; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
            }
            Console.WriteLine($"*** Fibonacci number is {sum}. ****");
            return sum;
        }

        //**********************************************************************************************************
        static void Main(string[] args)
        {
            // User enter two number to sum and divide
            Console.WriteLine("Please, enter two intiger numbers ");
            string? num1st = Console.ReadLine() ;
            string? num2st = Console.ReadLine() ;
            if (string.IsNullOrEmpty(num1st) || string.IsNullOrEmpty(num2st)) 
            {
                Console.WriteLine("Please, try again ");
                return;
            }
            int num1= int.Parse(num1st);
            int num2 = int.Parse(num2st);            
            int Sum2 = Sum(num1 , num2);
            Div(num1, num2);
            // User enter three numbers to sum
            Console.WriteLine("Please, enter three intiger numbers ");
            string? num21st = Console.ReadLine();
            string? num22st = Console.ReadLine();
            string? num23st = Console.ReadLine();
            if (string.IsNullOrEmpty(num21st) || string.IsNullOrEmpty(num22st) || string.IsNullOrEmpty(num23st))
            {
                Console.WriteLine("Please, try again ");
                return;
            }
            int num21 = int.Parse(num21st);
            int num22 = int.Parse(num22st);
            int num23 = int.Parse(num23st);
            int Sum3 = Sum(num21, num22, num23);
            // User enter one number to define it odd or even
            Console.WriteLine("Please, enter an intiger numbers ");
            string? num31st = Console.ReadLine();
            if (string.IsNullOrEmpty(num31st))
            {
                Console.WriteLine("Please, try again ");
                return;
            }
            int num31 = int.Parse(num21st);
            var Result = OddEven(num31);
            // User enter two numbers to compare
            Console.WriteLine("Please, enter two intiger numbers ");
            string? num41st = Console.ReadLine();
            string? num42st = Console.ReadLine();
            if (string.IsNullOrEmpty(num41st) || string.IsNullOrEmpty(num42st))
            {
                Console.WriteLine("Please, try again ");
                return;
            }
            int num41 = int.Parse(num41st);
            int num42 = int.Parse(num42st);
            Min(num41, num42);
            // User enter five numbers to compare
            Console.WriteLine("Please, enter five intiger numbers ");
            string? num51st = Console.ReadLine();
            string? num52st = Console.ReadLine();
            string? num53st = Console.ReadLine();
            string? num54st = Console.ReadLine();
            string? num55st = Console.ReadLine();
            if (string.IsNullOrEmpty(num51st) || string.IsNullOrEmpty(num52st) || string.IsNullOrEmpty(num53st) || string.IsNullOrEmpty(num54st) || string.IsNullOrEmpty(num55st))
            {
                Console.WriteLine("Please, try again ");
                return;
            }
            int num51 = int.Parse(num51st);
            int num52 = int.Parse(num52st);
            int num53 = int.Parse(num53st);
            int num54 = int.Parse(num54st);
            int num55 = int.Parse(num55st);
            Min(num51, num52, num53, num54, num55);

            // To find Fibonacci number
            Console.WriteLine("Please, enter number of Fibonacci series ");
            string? number = Console.ReadLine();
            if (string.IsNullOrEmpty(number))
            {
                Console.WriteLine("Please, try again ");
                return;
            }
            var num= int.Parse(number);
            Result = Fibonacci(num);

        }
    }
}
