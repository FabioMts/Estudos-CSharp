using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua teste", "12345678", "Hortolândia", "SP");

                Cliente cliente = new Cliente("Fabio", "123456", "456789", endereco);

                ContaBancaria conta = new ContaBancaria(cliente);

                Console.WriteLine("Conta: "+ conta.Situacao + ": " + conta.NumeroConta + " - " + conta.DigitoVerificador);

                conta.Abrir("abc123456789");

                Console.WriteLine("Conta: " + conta.Situacao + ": " + conta.NumeroConta + " - " + conta.DigitoVerificador);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
                        
        }
    }
}
