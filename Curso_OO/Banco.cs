using System.Globalization;

namespace Curso_OO
{
    internal class Banco
    {
        public string Nome { get; set; }
        public int NumConta { get; private set; }

        public double Inicial { get; private set; }

        CultureInfo CI = CultureInfo.InvariantCulture;

        public Banco(int numConta, string nome)
        {
            NumConta = numConta;
            Nome = nome;
        }

        public Banco(int numConta, string nome, double inicial) : this(numConta, nome)
        {
            AdicionarDeposito(inicial);
        }


        public override string ToString()
        {
            return "Conta " + NumConta + ", Titular: " + Nome + ", Saldo: $" + SaldoTotal().ToString("F2", CI);
        }

        public double SaldoTotal()
        {
            return Inicial;
        }

        public void AdicionarDeposito(double quantidade)
        {
            Inicial += quantidade;
        }

        // Taxa de 5 reais no saque.
        public void AdicionarSaque(double quantidade)
        {
            Inicial -= quantidade + 5;
        }


    }
}
