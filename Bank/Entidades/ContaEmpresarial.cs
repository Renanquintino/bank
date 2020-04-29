using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Entidades
{
    class ContaEmpresarial : ContaBancaria
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresarial()
        {

        }

        public ContaEmpresarial(string titular, int agencia, int numeroDaConta, double saldo, double limiteEmprestimo)
            :base(titular,agencia,numeroDaConta,saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double quantia)
        {
            if(quantia<= LimiteEmprestimo)
            {
                Saldo += quantia;
            }
        }

    }


}
