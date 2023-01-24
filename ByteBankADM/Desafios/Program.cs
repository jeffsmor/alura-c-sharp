using Desafios;

Console.WriteLine("Olá, Boas Vindas ao Calculatrix!");
Operacoes operacoes = new Operacoes();
Console.WriteLine("O valor é: " + operacoes.Soma.Calcular(10, 10));
Console.WriteLine("O valor é: " + operacoes.Subtracao.Calcular(30, 15));
Console.WriteLine("O valor é: " + operacoes.Divisao.Calcular(657, 98));
Console.WriteLine("O valor é: " + operacoes.Multiplicacao.Calcular(9, 48));

Console.ReadKey();