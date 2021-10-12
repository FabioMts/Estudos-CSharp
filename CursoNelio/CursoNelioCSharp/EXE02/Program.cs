using System;

namespace EXE02
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario f = new Funcionario();


            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salario bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Imposto: " + f.Imposto);
            Console.WriteLine();
            Console.WriteLine(f);

            Console.WriteLine();

            Console.WriteLine("Deseja aumentar o salário em qual porcentagem: ");
            double porcent = double.Parse(Console.ReadLine());
            f.AumentarSalario(porcent);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(f);
        }
    }
}
