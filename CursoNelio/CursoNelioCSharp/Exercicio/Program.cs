using Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for(int i=1; i <=n;i++)
            {
                Console.WriteLine($"Tax Payer{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if(ch == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }else
                {
                    Console.Write("Number of Employees: ");
                    int employeesNumber = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, employeesNumber));
                }

            }
            double sum = 0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach(TaxPayer taxPayer in list)
            {
                double tax = taxPayer.Tax();
                Console.WriteLine(taxPayer.ToString());
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("Total Taxes: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
