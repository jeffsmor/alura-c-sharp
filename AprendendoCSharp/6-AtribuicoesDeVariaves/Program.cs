using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6 - Atribuição de variáveis");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna);

        idade = 25;

        Console.WriteLine("Digite Enter para fechar...");
        Console.ReadLine();
    }
}