using System;

namespace Conditional_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to accept two integers and check whether
            //they are equal or not.
            //Test Data :
            //Input 1st number: 5
            //Input 2nd number: 5
            //Expected Output :
            //5 and 5 are equal

            Console.Write("Input 1st number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2st number");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("{0} equals {1}", a, b);
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("{0} doesn't equal {1}", a, b);
            }



        }
    }
}
