using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Cliente;
using ByteBank.Exceptions;

namespace ByteBank.Conta
{
    public class Corrente : IComparable<Corrente>
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
        public double Saldo { get; set; }

        public Corrente(int numeroAgencia, string conta)
        {
            this.NumeroAgencia = numeroAgencia;
            this.Conta = conta;
            this.Titular = new Titular();

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

        public Corrente(int numeroAgencia)
        {
            this.NumeroAgencia = numeroAgencia;
            this.Conta = Guid.NewGuid().ToString().Substring(0, 8);
            this.Titular = new Titular();

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
            Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;

                return true;
            }
            else
            {
                throw new SaldoInsuficienteException("Saldo insuficiente!");
            }
        }

        public bool Tranferir(double valor, Corrente destino)
        {
            if (Saldo < valor)
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
            Console.WriteLine("Saldo:" + this.Saldo);
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.Saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.Saldo;
        }

        public int CompareTo(Corrente? outro)
        {
            if (outro == null)
            {
                return 1;
            }
            else
            {
                return this.numeroAgencia.CompareTo(outro.numeroAgencia);
            }
        }

        public override string ToString()
        {
            return $" === DADOS DA CONTA === \n" +
                            $"Número da Conta : {this.Conta} \n" +
                            $"Número da Agência : {this.numeroAgencia} \n" +
                            $"Saldo da Conta: {this.GetSaldo()} \n" +
                            $"Titular da Conta: {this.Titular.Nome} \n" +
                            $"CPF do Titular  : {this.Titular.Cpf} \n" +
                            $"Profissão do Titular: {this.Titular.Profissao}\n\n";
        }
    }
}
