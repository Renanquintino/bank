using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Entidades
{
    class ContaBancaria
    {
        public string Titular { get; private set; }
        public int Agencia { get; private  set; }

        public int NumeroDaConta { get; private set; }

        public double Saldo { get; protected set; }

        public ContaBancaria()
        {
        }

        public ContaBancaria(string titular, int agencia, int numeroDaConta, double saldo)
        {
            Titular = titular;
            Agencia = agencia;
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
        }

        public void Saque (double quantia)
        {
            Saldo -= quantia;
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
    }
}
