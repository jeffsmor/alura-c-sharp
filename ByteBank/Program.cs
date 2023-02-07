using ByteBank;
using ByteBank.Cliente;
using ByteBank.Conta;
using ByteBank.Exceptions;
using ByteBank.Utilitarios;
using System.Collections;

#region
/*Corrente contaDoAndre = new Corrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numeroAgencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);*/

/*contaDoAndre.Depositar(101);

Console.WriteLine("Saldo da conta do André pós depósito = " + contaDoAndre.saldo);

if (contaDoAndre.Sacar(300) == true)
{
    Console.WriteLine("Saldo da conta do André pós saque = " + contaDoAndre.saldo);
}
else
{
    Console.WriteLine("Saldo insulficiente para saque.");
}*/

/*Corrente contaDaMaria = new Corrente();
contaDaMaria.titular = "Maria SOuza";
contaDaMaria.numeroAgencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

contaDoAndre.Tranferir(50, contaDaMaria);

Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

Console.WriteLine();
contaDoAndre.ExibirDadosDaConta();
Console.WriteLine();
contaDaMaria.ExibirDadosDaConta();
*/

/*Titular titular = new Titular();
titular.nome = "André Silva";
titular.cpf = "1234567890";
titular.profissao = "Analista";

Corrente conta = new Corrente();
conta.titular = titular;
conta.conta = "1010-X";
conta.numeroAgencia = 15;
conta.saldo = 100;

Console.WriteLine("Titular = " + conta.titular.nome);
Console.WriteLine("CPF = " + conta.titular.cpf);
Console.WriteLine("Profissão = " + conta.titular.profissao);
Console.WriteLine("Nº conta = " + conta.conta);
Console.WriteLine("Nº agência = " + conta.numeroAgencia);
Console.WriteLine("Saldo = " + conta.saldo);*/

/*Corrente conta = new Corrente();
conta.NumeroAgencia = 18;
conta.SetSaldo(200);
Console.WriteLine(conta.GetSaldo());
Console.WriteLine(conta.NumeroAgencia);*/

/*Corrente conta = new Corrente(18, "1010-X");
conta.SetSaldo(500);

Console.WriteLine(conta.GetSaldo());
Console.WriteLine(conta.NumeroAgencia);
Console.WriteLine(conta.Conta);*/

/*Corrente conta1 = new Corrente(283, "1234-X");
Console.WriteLine(Corrente.TotalDeContasCriadas);

Corrente conta2 = new Corrente(284, "9874-Z");
Console.WriteLine(Corrente.TotalDeContasCriadas);

Corrente conta3 = new Corrente(285, "1111-Z");
Console.WriteLine(Corrente.TotalDeContasCriadas);*/
#endregion

#region
/*
try
{
    Corrente corrente = new Corrente(0, "1234-X");
    *//*
        corrente.Sacar(50);
        Console.WriteLine(corrente.GetSaldo());
        corrente.Sacar(150);
        Console.WriteLine(corrente.GetSaldo());
    *//*
}
catch (ArgumentException e)
{
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(e.Message);
    Console.WriteLine(e.ParamName);
    Console.WriteLine(e.StackTrace);
}
catch (SaldoInsuficienteException e)
{
    Console.WriteLine("Operação negada! Saldo insuficient!");
    Console.WriteLine(e.Message);
}
*/
#endregion

#region
/*
LeitorDeArquivo leitor = new LeitorDeArquivo("das.txt");

try
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}
catch (IOException e)
{
    Console.WriteLine("Leitura de arquivo interrompida!");
}
finally
{
    leitor.Dispose();
}
*/
#endregion

Console.WriteLine("Boas vindas ao ByteBank Atendimento.");

void TestaArrayInt()
{
    int[] idades = new int[5];

    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho array: {idades.Length}");

    int acumulador = 0;

    for (int i = 0; i < idades.Length; i++)
    {
        Console.WriteLine($"Índice [{i}] = {idades[i]}");
        acumulador += idades[i];
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades: {media}");
}

// TestaArrayInt();

void TestaBuscaPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i + 1}ª palavra:");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite a palavra a ser encontrada:");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}.");
            break;
        }
    }
}

/*TestaBuscaPalavra();*/

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

void TestaMediana(Array array)
{
    if (null == array || 0 == array.Length)
    {
        Console.WriteLine("Array para cálculo de mediana está vazio.");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1] / 2);

    Console.WriteLine($"Com base na amostra mediana = {mediana}");
}

/*TestaMediana(amostra);*/

void TestaArrayDeContasCorrentes()
{
    ListaDeContas listaDeContas = new ListaDeContas();

    listaDeContas.Adicionar(new Corrente(874, "5679787-A"));
    listaDeContas.Adicionar(new Corrente(874, "4456668-B"));
    listaDeContas.Adicionar(new Corrente(874, "7781438-C"));

    var conta1 = new Corrente(963, "123456-X");
    listaDeContas.Adicionar(conta1);

    /*
     * 
    listaDeContas.ExibeLista();

    Console.WriteLine("============");

    listaDeContas.Remover(conta1);
    listaDeContas.ExibeLista();
    */

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        Corrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.NumeroAgencia}");
    }
}

/*TestaArrayDeContasCorrentes();*/

void PegarCorrentecomMaiorSaldo()
{
    ListaDeContas listaDeContas = new ListaDeContas();

    Corrente corrente1 = new Corrente(874, "5679787-A");
    corrente1.Depositar(565);

    Corrente corrente2 = new Corrente(874, "4456668-B");
    corrente2.Depositar(655);

    Corrente corrente3 = new Corrente(874, "7781438-C");
    corrente3.Depositar(558);

    listaDeContas.Adicionar(corrente1);
    listaDeContas.Adicionar(corrente2);
    listaDeContas.Adicionar(corrente3);

    listaDeContas.GetCorrenteMaiorSaldo();
}

/*PegarCorrentecomMaiorSaldo();*/

Corrente conta1 = new Corrente(95, "123456-X") { Titular = new Titular() { Cpf = "11111", Nome = "Henrique" } };
Corrente conta2 = new Corrente(95, "951258-X") { Titular = new Titular() { Cpf = "22222", Nome = "Pedro" } };
Corrente conta3 = new Corrente(94, "987321-W") { Titular = new Titular() { Cpf = "33333", Nome = "Marisa" } };

conta1.SetSaldo(100);
conta2.SetSaldo(200);
conta3.SetSaldo(300);

List<Corrente> _listaDeContas = new List<Corrente>() { conta1, conta2, conta3 };

void AtendimentoCliente()
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
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                case '3':
                    RemoverConta();
                    break;
                case '4':
                    OrdenarContas();
                    break;
                case '5':
                    PesquisarContas();
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

void PesquisarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===    PESQUISAR CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Deseja pesquisar por (1) NUMERO DA CONTA ou (2)CPF TITULAR ? ");

    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            {
                Console.Write("Informe o número da Conta: ");
                string _numeroConta = Console.ReadLine();
                Corrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                Console.WriteLine(consultaConta.ToString());
                Console.ReadKey();
                break;
            }
        case 2:
            {
                Console.Write("Informe o CPF do Titular: ");
                string _cpf = Console.ReadLine();
                Corrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                Console.WriteLine(consultaCpf.ToString());
                Console.ReadKey();
                break;
            }
        default:
            Console.WriteLine("Opção não implementada.");
            break;
    }
}

Corrente ConsultaPorCPFTitular(string? cpf)
{
    Corrente conta = null;

    for (int i = 0; i < _listaDeContas.Count; i++)
    {
        if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
        {
            conta = _listaDeContas[i];
        }
    }

    return conta;
}

Corrente ConsultaPorNumeroConta(string? numeroConta)
{
    Corrente conta = null;

    for (int i = 0; i < _listaDeContas.Count; i++)
    {
        if (_listaDeContas[i].Conta.Equals(numeroConta))
        {
            conta = _listaDeContas[i];
        }
    }

    return conta;
}

void OrdenarContas()
{
    _listaDeContas.Sort();
    Console.WriteLine("... Lista de Contas ordenadas ...");
    Console.ReadKey();
}

void RemoverConta()
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

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");
    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    Corrente conta = new Corrente(numeroAgencia, numeroConta);

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

void ListarContas()
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
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Conta : " + item.Conta);
        Console.WriteLine("Saldo da Conta : " + item.GetSaldo());
        Console.WriteLine("Titular da Conta: " + item.Titular?.Nome);
        Console.WriteLine("CPF do Titular  : " + item.Titular?.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular?.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }

}

AtendimentoCliente();

List<string> nomesDosEscolhidos = new List<string>()
{
    "Bruce Wayne",
    "Carlos Vilagran",
    "Richard Grayson",
    "Bob Kane",
    "Will Farrel",
    "Lois Lane",
    "General Welling",
    "Perla Letícia",
    "Uxas",
    "Diana Prince",
    "Elisabeth Romanova",
    "Anakin Wayne"
};

void EncontrarNone(string nome)
{
    if (nomesDosEscolhidos.Contains(nome))
    {
        Console.WriteLine($"O nome {nome} foi encontrado na lista com sucesso!");
    }
    else
    {
        Console.WriteLine($"O nome {nome} não foi encontrado na lista!");
    }
}

/*EncontrarNone("Anakin Wayne2");*/
