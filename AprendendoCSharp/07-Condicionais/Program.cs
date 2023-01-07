using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhado, pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }
        }

        Console.WriteLine("Digite Enter para fechar...");
        Console.ReadLine();
    }
}