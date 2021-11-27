//Objetivo: Calcular a distância, em quilômetros, percorrida pela luz em um intervalo de tempo no formato “HH:MM:SS”. Considerar a velocidade de luz como 300 mil km/s.
using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS");
    string time = Console.ReadLine();
    string[] slplitterTime = time.Split(":");
    ulong hours = (ulong.Parse(slplitterTime[0]) * 3600);
    ulong minutes = (ulong.Parse(slplitterTime[1]) * 60);
    ulong seconds = ulong.Parse(slplitterTime[2]);
    ulong totalTime = hours + minutes + seconds;
    ulong distance = totalTime * 300000;
    Console.WriteLine($"A luz percorreu {distance} km nesse intervalo");
  }
}