using System;

namespace Exersize3
{
    class Program
    {
        //3. ввести в консоль 2 числа создать методы :
        //сумма чисел, произведение, деление результат методов - 
        //вывод посчитанного значения этих двух чисел в консоль
        public static void Main(string[] args)
        {          
            Console.Write("Input 1st number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input 2st number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double d = Devision(a, b);
            Console.Write("Result of devision by {0} and {1} is {2}", a, b, d);
            Console.WriteLine("\n\n");

            double s = Sum(a, b);

            Console.Write("Result of sum of {0} and {1} is {2}", a, b, s);
            Console.WriteLine("\n\n");
            double m = Multiplication(a, b);
            Console.Write("Result of multiplication of {0} and {1} is {2}", a, b, m);
            Console.WriteLine("\n\n");

             double Devision(double a, double b)
            {
                return a/b;
            }

             double Sum(double a, double b)
            {
                return a +b;
            }
             double Multiplication(double a, double b)
            {
                return a * b;
            }
        }
    }
}

