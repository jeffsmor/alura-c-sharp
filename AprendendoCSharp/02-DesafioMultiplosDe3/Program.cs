using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio 2 - Múltiplos de 3");

        //solução1
        for (int numero = 1; numero <= 100; numero++)
        {
            if (numero % 3 == 0)
            {
                Console.WriteLine(numero);
            }
        }

        //solução2
        for (int numero = 3; numero <= 100; numero += 3)
        {
            Console.WriteLine(numero);
        }

        Console.WriteLine("Digite Enter para fechar...");
        Console.ReadLine();
    }
}