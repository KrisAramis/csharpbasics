using System;

namespace Yulia_Exersize2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n, sum = 0;
            Console.Write("Input n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The first N natural numbers are: ");

            if (n <= 100)
            {

                for (int i = 1; i <= n; i++)
                {
                    Console.Write("{0} ", i);
                    sum += i;

                }
                Console.Write("\nThe Sum of Natural Number upto {0} terms : {1} \n", n, sum);
            }

            else
            {
                Console.WriteLine("Not acceptable");
            }
            Console.ReadKey();
        }
    }
}
