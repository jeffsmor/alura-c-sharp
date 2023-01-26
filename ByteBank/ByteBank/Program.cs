using ByteBank;
using ByteBank.Cliente;
using ByteBank.Conta;
using ByteBank.Exceptions;

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