using System;
using System.Collections.Generic;

namespace Developer.Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            List<string> list1 = new List<string>();
            list1.Add("Fernando");
            list1.Add("Lucas");

            int length = list1.Count;
            list1.ForEach(nome =>
            {
                count++;
                string symbol = count != length ? ", " : ".";
                Console.Write($"{nome}{symbol}");
            });
            Console.WriteLine("\n============================\n");

            count = 0;
            List<string> list2 = new List<string> { "Gomes", "Souza" };
            int length2 = list2.Count;
            Console.WriteLine(length);
            foreach (var nome2 in list2)
            {
                count++;
                string symbol = count != length2 ? ", " : ".";
                Console.Write($"{nome2}{symbol}");
            }
            Console.WriteLine("\n============================\n");
        }
    }
}
