using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Cliente;

namespace ByteBank.Conta
{
    public class Corrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return this.numeroAgencia; }

            private set
            {
                if (value > 0) { this.numeroAgencia = value; }
            }
        }

        public string? Conta { get; set; }
        public Titular? Titular { get; set; }
        private double saldo = 100;

        public Corrente(int numeroAgencia, string conta)
        {
            this.NumeroAgencia = numeroAgencia;
            this.Conta = conta;
            TotalDeContasCriadas++;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Tranferir(double valor, Corrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);

                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular:" + this.Titular?.Nome);
            Console.WriteLine("Conta:" + this.Conta);
            Console.WriteLine("Número da agência:" + this.numeroAgencia);
            Console.WriteLine("Saldo:" + this.saldo);
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }
    }
}
