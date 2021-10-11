using System;

namespace CursoNelioCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número maior que 1 e menor que 1000");
            int x = int.Parse(Console.ReadLine());
            if( 1<= x && x <= 1000)
            {          
                    for(int i=1; i <=x; i+=2)
                    {
                    Console.WriteLine(i);
                    }
            }
            else
            {
                Console.WriteLine("STACKOVERFLOW");
            }
        }
    }
}
