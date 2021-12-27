using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite a média da disciplina");
    int m = int.Parse(Console.ReadLine());

    if (m >= 0 && m <= 100) { // 0 <= m <= 100
      Console.WriteLine("Nota válida");
    }
    if (!(m >= 0 && m <= 100)) { // 0 <= m <= 100
      Console.WriteLine("Nota inválida");
    }
    if (m < 0 || m > 100) { // 0 <= m <= 100
      Console.WriteLine("Nota inválida");
    }
 
    if (m >= 0 && m <= 100) { // 0 <= m <= 100
      Console.WriteLine("Nota válida");
    }
    else { // 0 <= m <= 100
      Console.WriteLine("Nota inválida");
    }
 
 
  }
}