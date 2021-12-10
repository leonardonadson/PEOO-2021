//https://www.beecrowd.com.br/judge/pt/problems/view/1011
//Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.

using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o raio da esfera:");
    double R = double.Parse(Console.ReadLine());
    double pi = 3.14159;
    double VOLUME = (4/3.0) * pi * (R*R*R);
    Console.WriteLine($"VOLUME = {VOLUME:n3}");
  }
}