using System;

public class Program {
  
  public static void Main() {
    string aposta = Console.ReadLine();
    string result = Console.ReadLine();
    string[] a = aposta.Split(' '); // a[0] ... a[5]
    string[] r = result.Split(' '); // r[0] ... r[5]
    int s = 0;

    if (a[0] == r[0] || a[0] == r[1] || a[0] == r[2] ||
        a[0] == r[3] || a[0] == r[4] || a[0] == r[5]) s++;

    if (a[1] == r[0] || a[1] == r[1] || a[1] == r[2] ||
        a[1] == r[3] || a[1] == r[4] || a[1] == r[5]) s++;

    ...

    if (a[5] == r[0] || a[5] == r[1] || a[5] == r[2] ||
        a[5] == r[3] || a[5] == r[4] || a[5] == r[5]) s++;

    if (s < 3) Console.WriteLine("azar");
    if (s == 3) Console.WriteLine("terno");
    if (s == 4) Console.WriteLine("quadra");
    if (s == 5) Console.WriteLine("quina");
    if (s == 6) Console.WriteLine("sena");
  }
}