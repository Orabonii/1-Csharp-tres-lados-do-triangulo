using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário que insira os três lados do triângulo
        Console.WriteLine("Digite o comprimento do primeiro lado do triângulo:");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o comprimento do segundo lado do triângulo:");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o comprimento do terceiro lado do triângulo:");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        // Verifica se os lados formam um triângulo válido
        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            Console.WriteLine("Os lados inseridos formam um triângulo válido.");
        }
        else
        {
            Console.WriteLine("Os lados inseridos não formam um triângulo válido.");
        }
    }
}
