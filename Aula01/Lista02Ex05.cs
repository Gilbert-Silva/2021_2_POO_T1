using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite o intervalo de tempo no formato HH:MM:SS");
    string t = Console.ReadLine();
    // HH:MM:SS
    // 01234567
    //int h = int.Parse(t.Substring(0, 2)); // t[0:2]
    //int m = int.Parse(t.Substring(3, 2)); // t[3:5]
    //int s = int.Parse(t.Substring(6, 2)); // t[6:8]

    string[] v = t.Split(':');
    int h = int.Parse(v[0]); 
    int m = int.Parse(v[1]);
    int s = int.Parse(v[2]);

    long dist = (long)300000 * (s + m * 60 + h * 3600);
    Console.WriteLine($"A luz percorreu {dist} km nesse intervalo");
  }
}




