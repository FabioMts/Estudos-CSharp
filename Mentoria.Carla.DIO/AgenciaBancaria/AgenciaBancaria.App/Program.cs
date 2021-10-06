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
                Cliente cliente = new Cliente("", "123456", "456789", "Rua teste",
                "12345678", "Hortolândia", "SP");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
                        
        }
    }
}
