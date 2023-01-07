using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio 3 - Fatorial");

        int fatorial = 1;

        for (int i = 1; i <= 10; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }

        Console.WriteLine("Digite Enter para fechar...");
        Console.ReadLine();
    }
}