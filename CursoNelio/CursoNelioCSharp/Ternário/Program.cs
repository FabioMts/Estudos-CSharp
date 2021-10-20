using System;
using System.Globalization;

namespace Ternário
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);

            //SINTAXE

            // ( CONDIÇÃO ) ? VALOR-SE-VERDADEIRO : VALOR-SE-FALSO


            //EXEMPLOS:

            // (2 > 4) ? 50 : 80 -> 80
            // (10 != 3) ? "MARIA" : "ALEX" -> "MARIA"
        }
    }
}
