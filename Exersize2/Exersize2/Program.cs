using System;

namespace YuliaExersize
{
    public class Program
    {
        public static void Main(string[] args)
        {


            for (int i = 1; i <= 50; i++)
            {
                double a =  i % 3.0;
                double b = i % 5.0;
                if ((a == 0) && (b != 0))
                {
                    Console.WriteLine("{0} is devisible by 3 but not devisible by 5", i);
                    Console.WriteLine("Tutti");
                }
                else if ((b == 0) && (a != 0))
                {
                    Console.WriteLine("{0} is devisible by 5 but not devisible by 3", i);
                    Console.WriteLine("Frutti");
                }
                else if ((a == 0) && (b == 0))
                {
                    Console.WriteLine("{0} is devisible by 3 and is devisible by 5", i);
                    Console.WriteLine("Tutti-Frutti");
                }
            }
        }
    }
}
