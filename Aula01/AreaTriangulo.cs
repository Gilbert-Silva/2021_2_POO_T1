using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite a base do triangulo");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a altura do triangulo");
    double h = double.Parse(Console.ReadLine()); // h = float(input())
    double a = b * h / 2;
    Console.WriteLine($"A área = {a}");
  }
}