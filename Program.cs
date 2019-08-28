using System;

namespace WhiteBoard1
{
   public class Program
    {
        public static double DjKhalid(double number) //Using recursion
        {
            if (number < 0) throw new ArgumentOutOfRangeException("Insert a positive integer");
            if ((number == 0) || (number == 1)) return 1; //Factorial of 0 and 1 is 1
            return number * DjKhalid(number - 1); //Recursion 
        }
                static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Sum(-123));
            Console.WriteLine(DjKhalid(17));
        }
        public static int Sum(int number)
        {
            int temp = 0;
            int sum = (number % 10) + (number / 10);
            if (number < 1)
            {
                int answer = (number % 10) + (number / 10);
                temp += answer;
                if (temp < -9) // lowest single digit
                {
                    number = temp;
                    return Sum(number);
                }
                return temp;
            }
            else if (number > 0 && number < 10) return number;
            else if (number > 9)
            {
                temp += sum;
                if (temp > 9) // highest single digit
                {
                    number = temp;
                    return Sum(number);
                }
            }
            return temp;
        }
    }
}
