using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula poupança");

        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mês.
        double rendimento = 0.005;

        //mês 1
        //investimento = investimento + (investimento * rendimento);

        //mês 2
        //investimento = investimento + (investimento * rendimento);

        //mês 3
        //investimento = investimento + (investimento * rendimento);

        //Console.WriteLine(investimento);

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + (investimento * rendimento);
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);

            mes += 1;
        }

        Console.WriteLine("Digite Enter para fechar...");
        Console.ReadLine();
    }
}