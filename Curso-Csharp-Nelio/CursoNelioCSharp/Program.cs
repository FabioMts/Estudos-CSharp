using System;
using System.Globalization;

namespace CursoNelioCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com seu nome completo: ");
            string n = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int nq = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);


            Console.WriteLine(n);
            Console.WriteLine(nq);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);


        }
    }
}
