using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conveerões e outros tipos");

        double salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        long x = 200000000000;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Digite Enter para fechar...");
        Console.ReadLine();
    }
}