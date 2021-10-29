using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Entities
{
    class Company : TaxPayer
    {
        public int EmployeesNumber { get; set; }

        public Company(string name, double anualIncome, int employeesNumber) : base(name, anualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double Tax()
        {
            double tax;
            if(EmployeesNumber > 11)
            {
                tax = AnualIncome * 0.14;
            } else
            {
                tax = AnualIncome * 0.16;
            }

            return tax;
        }
    }
}
