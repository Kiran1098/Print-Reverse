using System;

namespace ConsoleApp_Learn_Programming_
{
    class Program
    {
        static int MaxValue() 
        {

            int[] numbers = new int[5] { 2, 5, 10, 20, 3 };
            int maxvalue = 0;

            foreach (var n in numbers)
            {
                if (n > maxvalue)
                {
                    maxvalue = n;
                }

            }

            return maxvalue;

        }

        static int MinValue()
        {

            int[] numbers = new int[5] { -2, -5, -10, -20, -3 };
            int minvalue = 0;

            foreach (var n in numbers)
            {
                if (n < minvalue)
                {
                    minvalue = n;
                }

            }

            return minvalue;

        }
        static void Main(string[] args)
        {


            //string input  = "Hellow World";
            //string output = input.Substring(input.Length - 3, 3);

            //Console.WriteLine($"Last threee Characters are {output}");
            //Console.WriteLine(input);


            Console.WriteLine(MaxValue());
            Console.WriteLine(MinValue());





        }
    }
}
