using System;
using System.Collections;

class Program {
  public static void Main() {
    int[] v = { 2, 4, 6 };
    IEnumerator x = v.GetEnumerator();
    x.MoveNext();
    Console.WriteLine(x.Current);
    x.MoveNext();
    Console.WriteLine(x.Current);

    Contato c1 = new Contato();
    c1.Nome = "Gilbert";
    Console.WriteLine(c1);
    Contato c2 = new Contato {
      Nome = "Gilbert",
      Email = "gilbert@email.com"
    };
    Console.WriteLine(c2);

    string s = "Java";
    Console.WriteLine(s.Length);
    //s.Length = 7;
    Console.WriteLine(v.Length);

  }
}

class Contato {
  public string Nome {get;set;}
  public string Email {get;set;}
  public string Fone {get;set;}
  public DateTime Nascimento {get;set;}
  public override string ToString() {
    return $"{Nome} {Email} {Fone} {Nascimento}";
  }
}