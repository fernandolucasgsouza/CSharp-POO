using System;
using System.Collections.Generic;

namespace Developer.Lista
{
    class Program
    {
        public dynamic Clone()
        {
            return this.MemberwiseClone();
        }

        static void Main(string[] args)
        {
            int count = 0;

            List<string> list1 = new List<string>();
            list1.Add("Fernando");
            list1.Add("Lucas");
            list1.Add("Maria");
            list1.Add("Leonardo");
            list1.Add("Marcos");
            list1.Add("Leopoldo");
            list1.Add("Mateus");
            list1.Add("Luiz");
            list1.Add("Lidio");


            int length = list1.Count;
            //Listar todos
            list1.ForEach(nome =>
            {
                count++;
                string symbol = count != length ? ", " : ".";
                Console.Write($"{nome}{symbol}");
            });
            Console.WriteLine("\n============================\n");

            count = 0;
            List<string> list2 = new List<string> { "Gomes", "Souza", "Leonardo" };
            int length2 = list2.Count;
            //Listar todos
            foreach (var nome2 in list2)
            {
                count++;
                string symbol = count != length2 ? ", " : ".";
                Console.Write($"{nome2}{symbol}");
            }
            Console.WriteLine("\n============================\n");

            //Listar primeiro casdastrado que começe com L 
            string first = list1.Find(x => x[0] == 'L');
            Console.WriteLine($"Primeiro nom a letra 'L' : {first}");

            //Listar ultimo casdastrado que começe com L 
            string last = list1.FindLast(x => x[0] == 'L');
            Console.WriteLine($"Ultimo nom a letra 'L' : {last}\n");

            //Primeira e ultima  posição de casdastrado que começe com L 
            int primera_posicao = list1.FindIndex(x => x[0] == 'L');
            int ultima_posicao = list1.FindLastIndex(x => x[0] == 'L');
            Console.WriteLine($"Primeira posição == 'L' : {primera_posicao};\nultima posição == 'L' : {ultima_posicao}\n");

            //Filtrar todos casdastrados que contenham 5 caracters 
            Console.Write($"Cadastrados com 5 caracteres : ");
            var filter_five = list1.FindAll(x => x.Length == 5);
            foreach (var item in filter_five)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine("\n============================\n");
            Console.WriteLine("REMOVE:\n");
            //REMOVE

            //Antes de remover
            Console.WriteLine("Todos Cadastrados:");
            foreach (var item in list1)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\n---\n");

            //1 cadastrado especifico
            string nome = "Mateus";
            Console.WriteLine($"Removendo: {nome}");
            list1.Remove(nome);
            foreach (var item in list1)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\n---\n");

            //todos cadastrados que começão com a letra 'M'
            Console.WriteLine($"Removendo que começam com a letra 'M'");
            list1.RemoveAll(x => x[0] == 'M');
            foreach (var item in list1)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\n---\n");

            //todos cadastrados que começão com a letra 'M'
            int posicao = 2;

            Console.WriteLine($"Removendo na posição : {posicao}");
            list1.RemoveAt(posicao);
            foreach (var item in list1)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\n---\n");


            //remove range 'M'

            int posicao_init = 2;
            int quantidade = 2;
            list1.RemoveRange(posicao_init, quantidade);
            Console.WriteLine($"Removendo a partir da posicao {posicao_init} o total de {quantidade} itens");
            foreach (var item in list1)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\n---\n");
        }
    }
}
