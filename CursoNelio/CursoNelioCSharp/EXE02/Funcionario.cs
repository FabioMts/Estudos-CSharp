using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE02
{
    class Funcionario
    {
        public String Nome;
        public double SalarioBruto;
        public double Imposto = 1000;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * (porcentagem / 100));
        }

        public override string ToString()
        {
            return Nome
                + ", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
