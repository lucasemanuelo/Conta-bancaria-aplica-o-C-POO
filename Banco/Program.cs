using System;
using System.Globalization;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: " );
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial (S/N)? ");
            char depIni = char.Parse(Console.ReadLine());
            Console.WriteLine();
            if (depIni == 'S' || depIni == 's')
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, deposito);
            }
            else
            {
                conta = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.Write("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para deposito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);

            Console.WriteLine();
            Console.Write("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);

            Console.WriteLine();
            Console.Write("Dados atualizados: ");
            Console.WriteLine(conta);
        }
    }
}