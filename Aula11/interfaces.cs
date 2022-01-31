using System;
using System.Collections;

class Program {
  public static void Main() {
    int x = 5;
    int y = 10;
    Console.WriteLine(x.CompareTo(y));
    Console.WriteLine(y.CompareTo(x));
    Console.WriteLine(y.CompareTo(10));

    if (x > y) Console.WriteLine("x é maior");
    if (x < y) Console.WriteLine("y é maior");
    if (x.CompareTo(y) < 0) Console.WriteLine("m é menor que y");

    int[] v = { 5, 8, 2, 10, 4};
    Array.Sort(v);
    foreach(int i in v)
      Console.WriteLine(i);


    string s = "Java";  
    string r = "C#";

    //if (s > r) { 
    //}
    if (s.CompareTo(r) > 0) {
      Console.WriteLine(s); 
    }
    if (r.CompareTo(s) > 0) {
      Console.WriteLine(r); 
    }
    
    string[] vs = { "Java", "C#", "Visual Basic", "Python", "Assembly"};
    Array.Sort(vs);
    foreach(string w in vs)
      Console.WriteLine(w);
    
    Aluno a1 = new Aluno { Nome = "Eduardo", Idade = 40 };
    Aluno a2 = new Aluno { Nome = "Gilbert", Idade = 35 };
    //Console.WriteLine(a1);
    //Console.WriteLine(a2);
    Aluno[] va = { a1, a2 };
    //a1.CompareTo(a2);
    Array.Sort(va); // IComparable - Idade
    foreach(Aluno vi in va)
      Console.WriteLine(vi);

    NomeComp nc = new NomeComp();  
    Array.Sort(va, nc); // IComparer - Nome
    foreach(Aluno vi in va)
      Console.WriteLine(vi);
    
    Turma t1 = new Turma();
    foreach(Aluno vi in t1)
      Console.WriteLine(vi); 

    IEnumerable t2 = new Turma();
    object t3 = new Turma();


    IComparable ic = "Java";
    Console.WriteLine(ic.CompareTo("C#"));
    //Console.WriteLine(ic.Substring(2, 2));
    //IComparable ic2 = new Turma();
    ic = 5;
    ic = new Aluno();    

  }
}

class Turma : IEnumerable {
  public Aluno[] alunos = new Aluno[10];
  public Turma() {
    alunos[0] = new Aluno { Nome = "George", Idade = 40 };
    alunos[1] = new Aluno { Nome = "Danielle", Idade = 35 };
  }
  public IEnumerator GetEnumerator() {
    return alunos.GetEnumerator();
  }
}

class Aluno : IComparable {
  public string Nome { get; set; }
  public int Idade { get; set; }
  public override string ToString() {
    return $"{Nome} {Idade}";
  }
  public int CompareTo(object obj) {
    Aluno aux = (Aluno) obj; // Type cast
    //if (this.Idade < aux.Idade) return -1;
    //if (this.Idade > aux.Idade) return 1;
    //return 0;
    return this.Idade.CompareTo(aux.Idade);
    //return this.Nome.CompareTo(aux.Nome);
  }
}

class NomeComp : IComparer {
  public int Compare(object obj1, object obj2) {
    Aluno aux1 = (Aluno) obj1; // Type cast
    Aluno aux2 = (Aluno) obj2; // Type cast
    return aux1.Nome.CompareTo(aux2.Nome);
  }
}