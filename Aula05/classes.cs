using System;

class Program {
  public static void Main() {
    Aluno x = null;
    // Console.WriteLine(x);
    x = new Aluno(); 
    x.SetNome("Gilbert");
    Console.WriteLine(x);
    Console.WriteLine(x.ToString());

    Aluno y = new Aluno("Carlos");
    Console.WriteLine(y);
    y.SetIdade(25);
    Console.WriteLine(y.GetNome());
    Console.WriteLine(y);
    //y.idade = 25;

    x = y;

    x.SetNome("Savio");
    y.SetIdade(22);
    Console.WriteLine(x);
    Console.WriteLine(y);

    // x = null;

    // int y; // Valor indefinido
    //Console.WriteLine(y);
  }
}

/*class Object {
  public virtual string ToString() {
  }


}
*/

//class Aluno : Object {
class Aluno {
  private string nome;  // atributos
  private string matricula;
  private int idade = 20;

  public Aluno() { }
  public Aluno(string n) {
    nome = n;
  }
  public void SetNome(string nome) {
    this.nome = nome;
    // self
  }
  public string GetNome() { 
    return nome;
  }
  public void SetIdade(int n) {
    if (n >= 0) idade = n;
  }
  
  public override string ToString() {
    // str
    //return "Olá, eu sou um aluno";
    return $"Nome = {nome}, Mat = {matricula}, Idade = {idade}";
  }
  
}