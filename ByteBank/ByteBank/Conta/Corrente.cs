using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Cliente;
using ByteBank.Exceptions;

namespace ByteBank.Conta
{
    public class Corrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        public static float TaxaOperacao { get; private set; }

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

            if (this.numeroAgencia <= 0)
            {
                throw new ArgumentException("Número de agência menor ou igual a zero!", nameof(this.numeroAgencia));
            }

            /*try
            {
                TaxaOperacao = 30 / TotalDeContasCriadas;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Ocorreu um erro! Não é possível fazer uma divisão por zero! {e.Message}");
            }*/

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
                throw new SaldoInsuficienteException("Saldo insuficiente!");
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
