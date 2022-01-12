using System;

class Program {
  public static void Main() {
    Console.Write("Informe o número de países: ");
    int k = int.Parse(Console.ReadLine());
    Pais[] vetor = new Pais[k];
    for (int i = 0; i < k; i++) {
      Console.Write("Nome: ");
      string nome = Console.ReadLine();
      Console.Write("Nº habitantes: ");
      int habs = int.Parse(Console.ReadLine());
      Console.Write("Área: ");
      double area = double.Parse(Console.ReadLine());
      Pais p = new Pais(nome, habs, area);
      vetor[i] = p;
    }       
    foreach(Pais p in vetor)
      Console.WriteLine(p);
  }
}

class Pais {
  private string nome;
  private int populacao;
  private double area;
  public Pais(string nome, int populacao, double area) {
    this.nome = nome;
    if (populacao > 0) this.populacao = populacao;
    if (area > 0) this.area = area;
  }
  public override string ToString() {
    return $"{this.nome} - {this.populacao} hab - {this.area} km2";
  }
}