using System;

namespace Exersize5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.подсчитать количество слов в тексте
            //в консоль введете предложение(любое)
            //выведете количество слов
            //почитайте про метод Split() для string)

            Console.Write("Input sentence.");
            int sum = 0;
            string a= Convert.ToString(Console.ReadLine());
            string[] words = a.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);            foreach(string s in words)
            {
                sum ++;
            }
            Console.WriteLine("number of words is:{0}", sum);

        }
    }
}
