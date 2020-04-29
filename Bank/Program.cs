using System;
using Bank.Entidades;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria("Renan",0796,25062004,199.99);
            Console.WriteLine("NuncBank");
            Console.WriteLine("agencia"+conta.Agencia);
            Console.WriteLine("conta"+conta.NumeroDaConta);
            Console.WriteLine("titular"+conta.Titular);
            Console.WriteLine("Saldo"+conta.Saldo);
            
        }
    }
}
