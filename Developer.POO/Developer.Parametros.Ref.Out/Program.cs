using System;

namespace Developer.Parametros.Ref.Out
{
    class Program
    {
        static void Main(string[] args)
        {

            double valueA = 3;
            Calculator.TripleRef(ref valueA);
            Console.WriteLine($"Valor triplicado: {valueA}");

            double tripleB;
            Calculator.TripleOut(10, out tripleB);
            Console.WriteLine($"Valor triplicado: {tripleB}");
        }
    }
}
