using System;
using System.Globalization;
using System.Threading;

class Program {
  public static void Main() {

    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

    int x = 5;
    string s = "C#";
    Produto d = new Produto();
    object obj = d;
    //int y = (int) obj;
    obj = 10;
    int y = (int) obj;

    DateTime z = DateTime.Now;
    TimeSpan t = new TimeSpan(1, 2, 0, 0);
    Console.WriteLine(t.Days);
    Console.WriteLine(t.Hours);

    Console.WriteLine(x);
    Console.WriteLine(s);
    Console.WriteLine(d);
    //Console.WriteLine(obj + obj);
    Console.WriteLine(y + y);
    Console.WriteLine(z);
    Console.WriteLine(z.Day);
    Console.WriteLine(z.DayOfWeek);
    Console.WriteLine(z.DayOfYear);
    Console.WriteLine(z.Month);
    Console.WriteLine($"{z:dd/MM/yyyy hh:mm}");
    Console.WriteLine($"{z:ddd}");
    Console.WriteLine($"{z:MMM}");
    Console.WriteLine($"{z:dddd}");
    Console.WriteLine($"{z:MMMM}");

    Console.WriteLine($"{3.56:c2}"); // currency
    Console.WriteLine(t);
    Console.WriteLine(z);
    Console.WriteLine(z.Add(t));
    
    DateTime dia = DateTime.Parse("2020-02-29");
    Console.WriteLine($"{dia:dddd}");

    DiadaSemana w = DiadaSemana.Terça;
    Console.WriteLine(w);
    Console.WriteLine((int) w);
    w = DiadaSemana.Segunda | DiadaSemana.Terça;
    Console.WriteLine(w);
    Console.WriteLine((int) w);

    dynamic v = 10;
    Console.WriteLine(v + v);
    // Console.WriteLine(v.Substring(0, 1));
    v = "10";
    Console.WriteLine(v + v);
    Console.WriteLine(v.Substring(0, 1));

    var k = 10;
    Console.WriteLine(k.GetType());
    k = "10";

  }
}

class Produto {

}

// Conjunto
[Flags]
enum DiadaSemana { Domingo = 0, Segunda = 1, Terça = 2, Quarta = 4, Quinta = 8, Sexta = 16, Sábado = 32 }

// Elementos
enum SituacaoBoleto { PagoTotal, PagoParcial, NaoPago }

enum EstadoCivil { Solteiro, Casado, Viuvo, Divorciado }

