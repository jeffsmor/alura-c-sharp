using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio Aliquota com ifs");

        double salario = 3300.0;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("Aliquota de 7.5% pode deduzior até R$ 142.");
        }

        if (salario > 2800.0 && salario <= 3751.0)
        {
            Console.WriteLine("Aliquota de 15% pode deduzior até R$ 350.");
        }

        if (salario > 3751.0 && salario <= 4664.0)
        {
            Console.WriteLine("Aliquota de 22.5% pode deduzior até R$ 636.");
        }

        Console.WriteLine("Digite Enter para fechar...");
        Console.ReadLine();
    }
}