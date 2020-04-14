using System;

namespace Exersize4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i;
            int sum = 0;
            Random rnd = new Random();



            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(20);
                Console.WriteLine("{0} element is: {1}", i, arr[i]);
                sum += arr[i];
            }
            Console.WriteLine("Sum of the elements:", sum);
            Console.ReadKey();


        }
    }
}
//4. заполнить массив рандомными числами от 1 до 20 (количество элементов в массиве - 5)
//вывести элементы массива в консоль
//и посчитать сумму элементов массива