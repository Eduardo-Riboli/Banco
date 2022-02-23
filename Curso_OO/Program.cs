using System;
using System.Globalization;

namespace Curso_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Banco contaBancaria;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titual da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char condicao = char.Parse(Console.ReadLine());

            if (condicao == 's' || condicao == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double inicial = double.Parse(Console.ReadLine(), CI);
                contaBancaria = new Banco(conta, nome, inicial);
            } else
            {
                contaBancaria = new Banco(conta, nome);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(contaBancaria);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double qte = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Dados da conta atualizados:");
            contaBancaria.AdicionarDeposito(qte);
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            qte = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Dados da conta atualizados:");
            contaBancaria.AdicionarSaque(qte);
            Console.WriteLine(contaBancaria);




            Console.ReadLine();
        }
    }
}
