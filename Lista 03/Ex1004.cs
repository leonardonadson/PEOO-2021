//https://www.beecrowd.com.br/judge/pt/problems/view/1004
// Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD. A seguir mostre a variável PROD com mensagem correspondente.   

using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o primeiro número a ser multiplicado:");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número a ser multiplicado:");
    int b = int.Parse(Console.ReadLine());
    int PROD = a * b;
    Console.WriteLine($"PROD = {PROD}");
  }
}

