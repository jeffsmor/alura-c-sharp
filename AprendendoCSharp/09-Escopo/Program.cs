using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9 - Escopo");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado!";
        }
        else
        {
            textoAdicional = "João não está acompanhado!";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Digite Enter para fechar...");
        Console.ReadLine();
    }
}