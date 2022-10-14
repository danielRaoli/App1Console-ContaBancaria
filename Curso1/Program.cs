using System;
using Curso1.Entities;

namespace Curso1{
    class Program
    {
        static void Main(string[] args)
        {
            Conta cont;
            Console.WriteLine("entre com os dados da conta: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("deseja fazer um deposito inicial ? [Y/N]");
            char op = char.Parse(Console.ReadLine().ToUpper());
            

            if(op == 'Y')
            {
                Console.WriteLine("entre com o deposito inicial: ");
                double depositIn = double.Parse(Console.ReadLine());
                cont = new Conta(numero, nome,depositIn);
            }
            else
            {
                cont = new Conta(numero, nome);
            }

            Console.WriteLine("digite o valor para deposito");
            double deposit = double.Parse(Console.ReadLine());
            cont.Deposito(deposit);
            Console.WriteLine(cont);
            Console.WriteLine("digite o valor de saque: ");
            double saque = double.Parse(Console.ReadLine());
            cont.Saque(saque);
            Console.WriteLine(cont);
            
        }
    }

}