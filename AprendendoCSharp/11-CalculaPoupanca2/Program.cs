using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula poupança 2");

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005; // rendimento de 0.5% (0.005) ao mês.
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
        }

        Console.WriteLine("Digite Enter para fechar...");
        Console.ReadLine();
    }
}