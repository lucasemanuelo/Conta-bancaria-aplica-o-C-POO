using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            Saldo = saldo;
        }

        public Conta(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }

        public void Saque(double saldo)
        {
            Saldo -= saldo + 5.00;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", Titular: " + Titular + ", Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
