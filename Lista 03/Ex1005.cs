//https://www.beecrowd.com.br/judge/pt/problems/view/1005
//Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11). Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a primeira nota do aluno:");
    double A = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a segunda nota do aluno:");
    double B = double.Parse(Console.ReadLine());
    double MEDIA = ((A * 3.5) + (B * 7.5))/11;
    Console.WriteLine($"MEDIA = {MEDIA:f5}");
  }
}