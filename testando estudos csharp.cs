using System;

class Program
{
    static void Main()
    {
        double a = 10.5;
        double b = 3.0;
        OperacoesBasicas(a, b);
    }

    static void OperacoesBasicas(double a, double b)
    {
        // Adição
        double resultadoAdicao = a + b;
        // Subtração
        double resultadoSubtracao = a - b;
        // Multiplicação
        double resultadoMultiplicacao = a * b;
        // Divisão (verificar se b é diferente de zero para evitar divisão por zero)
        double resultadoDivisao = 0.0;
        if (b != 0)
        {
            resultadoDivisao = a / b;
        }
        else
        {
            Console.WriteLine("Divisão por zero não é definida");
            return;
        }

        // Exibindo os resultados utilizando interpolação de strings
        Console.WriteLine($"Resultados para a = {a} e b = {b}:");
        Console.WriteLine($"Adição: {a} + {b} = {resultadoAdicao}");
        Console.WriteLine($"Subtração: {a} - {b} = {resultadoSubtracao}");
        Console.WriteLine($"Multiplicação: {a} * {b} = {resultadoMultiplicacao}");
        Console.WriteLine($"Divisão: {a} / {b} = {resultadoDivisao}");
    }
}
