using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Curso1.Entities
{
    class Conta
    {
        public int Numero {  get; private set; }

        public string Nome { get; set; }

        public double Saldo { get; private set; }

        public Conta(int numero, string nome) { 
            Numero = numero;
            Nome = nome;
        }

        public Conta(int numero,string nome,double depositoInicial) : this(numero, nome)
        {
            Saldo = depositoInicial;
        }


        public void Deposito(double deposit)
        {
            Saldo += deposit;
        }

        public void Saque(double saque) {
            Saldo -= (saque + 5.0);
        }

        public override string ToString()
        {
            return "Nome: " + Nome +
                " Numero: " + Numero +
                "Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }




    }
}
