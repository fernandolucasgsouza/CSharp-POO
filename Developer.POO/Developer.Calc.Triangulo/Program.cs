using System;
using System.Globalization;

namespace Developer.Calc.Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            TrianguloModel _trianguloX = new TrianguloModel();
            TrianguloModel _trianguloY = new TrianguloModel();

            Console.WriteLine("Entre com as medidas do Triangulo X");
            triangulo.SetValues(_trianguloX.Item);

            Console.WriteLine("Entre com as medidas do Triangulo Y");
            triangulo.SetValues(_trianguloY.Item);
            var areaX = triangulo.CalcArea(_trianguloX.Item);
            var areaY = triangulo.CalcArea(_trianguloY.Item);
            
            Console.WriteLine($"Área triangulo X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área triangulo Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{triangulo.ValidaMaior(areaX,"X", areaY,"Y")}");
        }
    }
}
