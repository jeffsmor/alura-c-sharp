using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        string cursos = @"Cursos disponíveis:
- Go
- C#
- Python
- Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Digite Enter para fechar...");
        Console.ReadLine();
    }
}