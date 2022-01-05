//Faça um programa que leia um vetor X[10]. Substitua a seguir, todos os valores nulos e negativos do vetor X por 1. Em seguida mostre o vetor X.

//Para cada posição do vetor, escreva "X[i] = x", onde i é a posição do vetor e x é o valor armazenado naquela posição.

using System;

class Program {
  public static void Main (string[] args) {
    
    int[] x = new int[10];

    for (int i = 0; i <= 9; i++){
      x[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i <= 9; i++){
      if (x[i] <= 0){
        x[i] = 1;
      }
    }

    for (int i = 0; i <= 9; i++){
      Console.WriteLine($"X[{i}] = {x[i]}");
    }
  }
}