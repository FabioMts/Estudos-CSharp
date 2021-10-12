using System;

namespace EXEC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Digite o valor da largura e altura do Retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());


            Console.WriteLine("AREA: " + ret.AreaRetangulo());
            Console.WriteLine("PERIMETRO: " + ret.Perimetro());
            Console.WriteLine("DIAGONAL: " + ret.Diagonal());

        }
    }
}
