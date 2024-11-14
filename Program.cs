using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Conta c = new Conta();

                Console.WriteLine("Informe o valor do saldo: ");
                double saldo = double.Parse(Console.ReadLine());
                c.SetSaldo(saldo);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            /*
            try
            {
                Console.WriteLine("Digite um valor: ");
                int valor = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(valor / 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Valor informado inválido.");
            }*/
        }
    }
}
