using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main() {
    Console.WriteLine(Proximo(2.5));

    Func<double, int> m = Proximo;
    Console.WriteLine(m(3.5));

    Func<double, int> m2 = x => 2 * (int)x;
    Console.WriteLine(m2(3.5));

    List<Aluno> la = new List<Aluno> {
      new Aluno { Nome="Daniela", Fone="5678", Matricula="20215678" },
      new Aluno { Nome="Alcides", Fone="1234", Matricula="20211234" },      
      new Aluno { Nome="Carlos", Fone="4321", Matricula="20214321" },      
      new Aluno { Nome="Ana", Fone="8765", Matricula="20218765" }      
    };

    foreach(Aluno a in la)
      Console.WriteLine(a);
  
    var r = la.Select(w => new { Nome=w.Nome, Matricula=w.Matricula });
    Console.WriteLine(r.GetType());

    string texto = "select top 4 Nome, Matricula from Aluno" +  // primary key
                   "order by Nome";

    foreach(var item in r)
      Console.WriteLine(item);
    
    foreach(var item in r)
      Console.WriteLine(item.Nome + " - " + item.Matricula);

    var r2 = from a in la select a.Nome; // operadores do linq
    foreach(string item in r2)
      Console.WriteLine(item);
    
    var r3 = la.Where(w => w.Nome.StartsWith("A"));
    foreach(var item in r3)
      Console.WriteLine(item);
    
    var r4 = Pesquisar(la);
    foreach(var item in r4)
      Console.WriteLine(item);

    var r5 = la.OrderByDescending(w => w.Nome);
    foreach(var item in r5)
      Console.WriteLine(item);

    
  
  }
  public static int Proximo(double x) {
    return (int)x + 1;
  }

  public static List<Aluno> Pesquisar(List<Aluno> la) {
    List<Aluno> r = new List<Aluno>();
    foreach(Aluno a in la)
      if(a.Nome.StartsWith("A")) r.Add(a);
    return r;
  }
}

class Aluno {
  public string Nome { get; set; }
  public string Fone { get; set; }
  public string Matricula { get; set; }
  public override string ToString() {
    return $"{Nome} - {Fone} - {Matricula}";
  }
}