//Objetivo: Calcular área, perímetro e diagonal de um retângulo, dados sua base e sua altura. Considerar que os valores podem ser números reais. Mostrar o resultado com duas casas decimais.
using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a base do retângulo:");
    double base1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a altura do retângulo:");
    double height = double.Parse(Console.ReadLine());
    double area = base1 * height;
    double perimeter = (2*base1) + (2*height);
    double diagonal = Math.Sqrt((base1*base1) + (height*height));
    Console.WriteLine($"Área = {area:f2} - Perímetro = {perimeter:f2} - Diagonal {diagonal:f2}");
  }
}