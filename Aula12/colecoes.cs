using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    Produto p1 = new Produto("Refri", 4.5);
    Produto p2 = new Produto("Arroz", 3);
    //Carrinho c = new Carrinho();
    Lista<Produto> c = new Lista<Produto>();
    c.Inserir(p1);
    c.Inserir(p2);
    Console.WriteLine(c.Listar());
    foreach(Produto obj in c.Listar())
      Console.WriteLine(obj);

    Aluno a1 = new Aluno("Rafael", "mat1");
    Aluno a2 = new Aluno("Lucas", "mat2");

    //Turma t = new Turma();
    Lista<Aluno> t = new Lista<Aluno>();
    t.Inserir(a1);
    t.Inserir(a2);
    Console.WriteLine(t.ToArray());
    foreach(Aluno obj in t.ToArray())
      Console.WriteLine(obj);
    /*
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(a1);
    Console.WriteLine(a2);
    */

    Lista<int> li = new Lista<int>();
    li.Inserir(10);
    li.Inserir(30);
    li.Inserir(20);
    li.Inserir(50);
    li.Inserir(40);
    foreach(int obj in li.ToArray())
      Console.WriteLine(obj);

    Lista<int> li2 = new Lista<int>();
    li2.Inserir(60);
    li2.Inserir(70);
    li2.Inserir(80);
    li2.Inserir(90);
    li2.Inserir(100);
    foreach(int obj in li2.ToArray())
      Console.WriteLine(obj);

    /*
    Lista< Lista<int> > l = new Lista<Lista<int>>();
    l.Inserir(li);
    l.Inserir(li2);
    foreach(Lista<int> obj in l.ToArray()) {
      Console.WriteLine(obj);
      foreach(int elem in obj.ToArray())
        Console.WriteLine(elem);
    }
    */

    List<int> li3 = new List<int>();
    li3.Add(10);
    li3.Add(30);
    li3.Add(20);
    li3.Add(50);
    li3.Add(40);
    foreach(int obj in li3.ToArray())
      Console.WriteLine(obj);
    Console.WriteLine(li3[0]);
    Console.WriteLine(li3[1]);
    Console.WriteLine(li3[2]);
    Console.WriteLine(li3[3]);
    Console.WriteLine(li3[4]);

    // Coleções
    /*
    Vetor - []
    Pilhas - LIFO
    Filas  - FIFO
    Dicionário não ordenado - Chave, Valor
    Dicionário ordenado - Chave IComparable, Valor
  */
    Mensagem<int>(10);
    Mensagem<string>("C#");
    Mensagem<Aluno>(a1);

  }

  public static void Mensagem<T>(T msg) {
    Console.WriteLine(msg);
  }
}

class Lista<T> where T : IComparable { // Vetor dinâmico []
  private T[] vetor = new T[10];
  private int k;
  public void Inserir(T obj) {
    if (k == vetor.Length) 
      Array.Resize(ref vetor, 2 * vetor.Length);
    vetor[k] = obj;
    k++;
  }
  public T[] Listar() {
    return vetor;
  }
  public T[] ToArray() {
    T[] aux = new T[k];
    Array.Copy(vetor, aux, k);
    Array.Sort(aux);
    return aux;
    //return vetor;
  }
}

class Carrinho {
  private Produto[] vetor = new Produto[10];
  private int k;
  public void Inserir(Produto obj) {
    vetor[k] = obj;
    k++;
  }
  public Produto[] Listar() {
    return vetor;
  }
}

class Carrinho2 {
  private List<Produto> vetor = new List<Produto>();
  public void Inserir(Produto obj) {
    vetor.Add(obj);
  }
  public List<Produto> Listar() {
    return vetor;
  }
  public void Excluir(Produto obj) {
    vetor.Remove(obj);
  }
}

class Turma {
  private Aluno[] vetor = new Aluno[10];
  private int k;
  public void Inserir(Aluno obj) {
    vetor[k] = obj;
    k++;
  }
  public Aluno[] Listar() {
    return vetor;
  }
}

class Produto : IComparable, IComparable<Produto> {
  private string nome;
  private double preco;
  public Produto(string n, double p) {
    this.nome = n;
    this.preco = p;
  }
  public override string ToString() {
    return $"{nome} - {preco}";
  }
  public int CompareTo(object obj) {
    Produto p = (Produto) obj;
    return this.nome.CompareTo(p.nome);
  }
  public int CompareTo(Produto obj) {
    //Produto p = (Produto) obj;
    return this.nome.CompareTo(obj.nome);
  }
}

class Aluno : IComparable {
  private string nome;
  private string matricula;
  public Aluno(string n, string m) {
    this.nome = n;
    this.matricula = m;
  }
  public override string ToString() {
    return $"{nome} - {matricula}";
  }
  public int CompareTo(object obj) {
    Aluno p = (Aluno) obj;
    return this.nome.CompareTo(p.nome);
  }
}