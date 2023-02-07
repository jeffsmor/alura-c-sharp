using ByteBank.Cliente;
using ByteBank.Conta;
using ByteBank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Atendimento
{
    public class Atendimento
    {
        private List<Corrente> _listaDeContas = new List<Corrente>() {
            new Corrente(95, "123456-X") { Saldo = 100, Titular = new Titular() { Cpf = "11111", Nome = "Henrique" } },
            new Corrente(95, "951258-X") { Saldo = 200,Titular = new Titular() { Cpf = "22222", Nome = "Pedro" } },
            new Corrente(94, "987321-W") { Saldo = 300,Titular = new Titular() { Cpf = "33333", Nome = "Marisa" } },
        };

        public void AtendimentoCliente()
        {
            try
            {
                char opcao = '0';

                while (opcao != '6')
                {
                    Console.Clear();
                    Console.WriteLine("===============================");
                    Console.WriteLine("===       Atendimento       ===");
                    Console.WriteLine("===1 - Cadastrar Conta      ===");
                    Console.WriteLine("===2 - Listar Contas        ===");
                    Console.WriteLine("===3 - Remover Conta        ===");
                    Console.WriteLine("===4 - Ordenar Contas       ===");
                    Console.WriteLine("===5 - Pesquisar Conta      ===");
                    Console.WriteLine("===6 - Sair do Sistema      ===");
                    Console.WriteLine("===============================");
                    Console.WriteLine("\n\n");
                    Console.Write("Digite a opção desejada: ");

                    try
                    {
                        opcao = Console.ReadLine()[0];
                    }
                    catch (Exception e)
                    {
                        throw new ByteBankException(e.Message);
                    }

                    switch (opcao)
                    {
                        case '1':
                            this.CadastrarConta();
                            break;
                        case '2':
                            this.ListarContas();
                            break;
                        case '3':
                            this.RemoverConta();
                            break;
                        case '4':
                            this.OrdenarContas();
                            break;
                        case '5':
                            this.PesquisarContas();
                            break;
                        case '6':
                            this.EncerrarAplicacao();
                            break;
                        default:
                            Console.WriteLine("Opção não implementada.");
                            break;
                    }
                }
            }
            catch (ByteBankException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

        private void PesquisarContas()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===    PESQUISAR CONTAS     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.Write("Deseja pesquisar por (1) NUMERO DA CONTA ou (2)CPF TITULAR ou (3) Nº AGÊNCIA : ");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.Write("Informe o número da Conta: ");
                        string _numeroConta = Console.ReadLine();
                        Corrente consultaConta = this.ConsultaPorNumeroConta(_numeroConta);
                        Console.WriteLine(consultaConta.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.Write("Informe o CPF do Titular: ");
                        string _cpf = Console.ReadLine();
                        Corrente consultaCpf = this.ConsultaPorCPFTitular(_cpf);
                        Console.WriteLine(consultaCpf.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.Write("Informe o Nº da Agência: ");
                        int _numeroAgencia = int.Parse(Console.ReadLine());
                        var contasPorAgencia = this.ConsultaPorAgencia(_numeroAgencia);
                        this.ExibirListaDeContas(contasPorAgencia);
                        Console.ReadKey();
                        break;
                    }
                default:
                    Console.WriteLine("Opção não implementada.");
                    break;
            }
        }

        private void ExibirListaDeContas(List<Corrente> contasPorAgencia)
        {
            if (contasPorAgencia == null)
            {
                Console.WriteLine(" ... A consulta não retornou dados ...");
            }
            else
            {
                foreach (var item in contasPorAgencia)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private List<Corrente> ConsultaPorAgencia(int numeroAgencia)
        {
            var consulta = (from conta in _listaDeContas
                            where conta.NumeroAgencia == numeroAgencia
                            select conta)
                            .ToList();

            return consulta;
        }

        private Corrente ConsultaPorCPFTitular(string? cpf)
        {
            /*
                Corrente conta = null;

                for (int i = 0; i < _listaDeContas.Count; i++)
                {
                    if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
                    {
                        conta = _listaDeContas[i];
                    }
                }

                return conta;
            */

            return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();
        }

        private Corrente ConsultaPorNumeroConta(string? numeroConta)
        {
            /*    
                Corrente conta = null;

                for (int i = 0; i < _listaDeContas.Count; i++)
                {
                    if (_listaDeContas[i].Conta.Equals(numeroConta))
                    {
                        conta = _listaDeContas[i];
                    }
                }

                return conta;
            */

            /*   return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();*/

            return (from conta in _listaDeContas
                    where conta.Conta == numeroConta
                    select conta).FirstOrDefault();
        }

        private void OrdenarContas()
        {
            _listaDeContas.Sort();
            Console.WriteLine("... Lista de Contas ordenadas ...");
            Console.ReadKey();
        }

        private void RemoverConta()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===      REMOVER CONTAS     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.Write("Informe o número da Conta: ");

            string numeroConta = Console.ReadLine();

            Corrente conta = null;

            foreach (var item in _listaDeContas)
            {
                if (item.Conta.Equals(numeroConta))
                {
                    conta = item;
                }
            }

            if (conta != null)
            {
                _listaDeContas.Remove(conta);

                Console.WriteLine("... Conta removida da lista! ...");
            }
            else
            {
                Console.WriteLine(" ... Conta para remoção não encontrada ...");
            }

            Console.ReadKey();
        }

        private void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===   CADASTRO DE CONTAS    ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.WriteLine("=== Informe dados da conta ===");

            Console.Write("Número da Agência: ");
            int numeroAgencia = int.Parse(Console.ReadLine());

            Corrente conta = new Corrente(numeroAgencia);
            Console.WriteLine($"Número da conta corrente: {conta.Conta}");

            Console.Write("Informe o saldo inicial: ");
            conta.Depositar(double.Parse(Console.ReadLine()));

            Console.Write("Infome nome do Titular: ");
            conta.Titular.Nome = Console.ReadLine();

            Console.Write("Infome CPF do Titular: ");
            conta.Titular.Cpf = Console.ReadLine();

            Console.Write("Infome Profissão do Titular: ");
            conta.Titular.Profissao = Console.ReadLine();

            _listaDeContas.Add(conta);
            Console.WriteLine("... Conta cadastrada com sucesso! ...");
            Console.ReadKey();
        }

        private void ListarContas()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===     LISTA DE CONTAS     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            if (_listaDeContas.Count <= 0)
            {
                Console.WriteLine("... Não há contas cadastradas! ...");
                Console.ReadKey();
                return;
            }
            foreach (Corrente item in _listaDeContas)
            {
                /*
                Console.WriteLine("===  Dados da Conta  ===");
                Console.WriteLine("Número da Conta : " + item.Conta);
                Console.WriteLine("Saldo da Conta : " + item.GetSaldo());
                Console.WriteLine("Titular da Conta: " + item.Titular?.Nome);
                Console.WriteLine("CPF do Titular  : " + item.Titular?.Cpf);
                Console.WriteLine("Profissão do Titular: " + item.Titular?.Profissao);
                */
                Console.WriteLine(item.ToString());
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.ReadKey();
            }

        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("... Encerrando a aplicação ...");
            Console.ReadKey();
        }
    }
}
