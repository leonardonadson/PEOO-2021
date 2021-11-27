//Objetivo: Calcular a média parcial de uma disciplina semestral, dadas as notas dos 1o e 2o bimestres (pesos 2 e 3). Considerar as notas com valores inteiros entre zero e cem.
using System;

class batattafrita {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a nota do primeiro bimestre da disciplina:");
    int testGrade1 = int.Parse (Console.ReadLine());
    Console.WriteLine ("Digite a nota do segundo bimestre da disciplina:");
    int testGrade2 = int.Parse (Console.ReadLine());
    int media = (testGrade1*2 + testGrade2*3)/5;
    Console.WriteLine ("Média parcial = " + media);
  }
}