using System;

public class Program {
  
  public static void Main() {
    int m = 0;
    do {
      Console.WriteLine("Digite a média da disciplina");
      m = int.Parse(Console.ReadLine());

      if (VerificarMedia(m)) { 
        Console.WriteLine("Nota válida");
      }
      else {
        Console.WriteLine("Nota inválida");
      }
    } while (!Testes.VerificarMedia(m));
  }

  public static bool VerificarMedia(int x) {
    if (x >= 0 && x <= 100) return true;
    else return false;
  } 

} 

class Testes {

  public static bool VerificarMedia(int x) {
    if (x >= 0 && x <= 100) return true;
    else return false;
  } 

}