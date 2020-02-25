using System;
using System.Globalization;

namespace Developer.Calc.Triangulo
{
    public class Triangulo
    {

        public Triangulo() { }

        public void SetValues(double[] triangulo)
        {
            int count = 0;
            while (count < triangulo.Length)
            {
                count++;
                Console.Write("Informe o valor #{0}: ", count);
                var value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                triangulo[count - 1] = value;
            }
        }

        /**
         * triangulo[0] = Ponto A
         * triangulo[1] = Ponto B
         * triangulo[2] = Ponto C
         */
        public double CalcArea(double[] triangulo)
        {
            double a = triangulo[0], 
                   b = triangulo[1], 
                   c = triangulo[2],
                   p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public string ValidaMaior(double item_a, string nome_item_a, double item_b, string nome_item_b)
        {
            var item = item_a > item_b ? nome_item_a : item_a < item_b ? nome_item_b : "Tamanhos Iguais";
            return $"Maior àrea : {item}";
        }
    }
}
