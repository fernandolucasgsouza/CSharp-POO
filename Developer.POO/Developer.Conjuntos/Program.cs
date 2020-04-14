using System;
using System.Collections.Generic;

namespace Developer.Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {


            HashSet<int> Conj_A = new HashSet<int>();
            Conj_A.Add(3);
            Conj_A.Add(5);
            Conj_A.Add(8);
            Conj_A.Add(9);
            Console.Write("A: ");
            foreach (var item in Conj_A) Console.Write($"{item} ");

            Console.Write("\n informe o numero que deseja [REMOVER] no conjunto A: ");
            int rm = int.Parse(Console.ReadLine());
            Conj_A.Remove(rm);
            Console.Write("A: ");
            foreach (var item in Conj_A) Console.Write($"{item} ");


            HashSet<int> Conj_B = new HashSet<int>();
            Conj_B.Add(3);
            Conj_B.Add(4);
            Conj_B.Add(5);

            Console.Write("\n informe o numero que deseja pesquisa no conjunto B: ");
            int value = int.Parse(Console.ReadLine());

            Console.Write("B: ");
            foreach (var item in Conj_B) Console.Write($"{item} ");
            if (Conj_B.Contains(value))
                Console.WriteLine($"\n ({value}) pertence ao conjunto B");
            else
                Console.WriteLine($"\n ({value}) não pertence ao conjunto B");


            //Mostra todo os itens EXCETOS o que tem em B
            //Console.WriteLine("número que tem em A mas não tem em B ");
            //Conj_A.ExceptWith(Conj_B);
            //foreach (var item in Conj_A) Console.Write($"{item} ");

            //Mostra interseção de A com B
            //Console.WriteLine("\n interceção entre A e B ");
            //Conj_A.IntersectWith(Conj_B);
            //foreach (var item in Conj_A) Console.Write($"{item} ");
            
            //Mostra união de A com B
            //Console.WriteLine("\n união A e B ");
            //Conj_A.UnionWith(Conj_B);
            //foreach (var item in Conj_A) Console.Write($"{item} ");




        }
    }
}
