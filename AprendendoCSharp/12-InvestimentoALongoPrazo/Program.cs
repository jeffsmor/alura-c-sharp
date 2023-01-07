using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Investimento a longo prazo");

        double rendimento = 1.005;
        double investimento = 1000;
        int duracaoAnos = 5;

        for (int anos = 1; anos <= duracaoAnos; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= rendimento;
            }

            rendimento += 0.001;
        }

        Console.WriteLine("Você terá depois de " + duracaoAnos + " anos R$ " + investimento);
        Console.WriteLine("Digite Enter para fechar...");
        Console.ReadLine();
    }
}