using ByteBankADM.Funcionarios;
using ByteBankADM.Utilitarios;

#region
/*Funcionario funcionario = new Funcionario("1234567890", 2000);
funcionario.Nome = "Pedro Malazartes";

Console.WriteLine(funcionario.Nome);
Console.WriteLine(funcionario.GetBonus());

Diretor diretor = new Diretor("9876543210");
diretor.Nome = "Roberta Silva";

Console.WriteLine(diretor.Nome);
Console.WriteLine(diretor.GetBonus());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(funcionario);
gerenciador.Registrar(diretor);

Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonificacao}");
Console.WriteLine($"Total de funcionarios: {Funcionario.TotalDeFuncionarios}");

funcionario.AumentarSalario();
diretor.AumentarSalario();

Console.WriteLine($"Salário do funcionário após aumento: {funcionario.Salario}");
Console.WriteLine($"Salário do diretor após aumento: {diretor.Salario}");*/
#endregion

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer designer = new Designer("1234567890");
    designer.Nome = "Ulisses Pinto";

    Diretor diretor = new Diretor("561652165622");
    diretor.Nome = "Paula Souza";

    Auxiliar auxiliar = new Auxiliar("6986252561");
    auxiliar.Nome = "Igor Dias";

    GerenteDeContas gerenteDeContas = new GerenteDeContas("56515611651");
    gerenteDeContas.Nome = "Camila Oliveira";

    gerenciador.Registrar(designer);
    gerenciador.Registrar(diretor);
    gerenciador.Registrar(auxiliar);
    gerenciador.Registrar(gerenteDeContas);

    Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonificacao}");
}

CalcularBonificacao();
