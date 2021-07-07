using System;

namespace Condotional_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to check whether a given number is even or odd.
            //Test Data : 15
            //Expected Output :
            //15 is an odd integer


            Console.Write("inpit number:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b % 2 == 0)

                Console.WriteLine("{0} is even", b);
            else

                Console.WriteLine("{0} is odd", b);

        }
    }
}
