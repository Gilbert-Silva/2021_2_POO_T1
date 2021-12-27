using System;

class Program {
  public static void Main() {
    Musica m1 = new Musica("Baby Shark", "Pinkfong");
    Musica m2 = new Musica("Transilvania", "Iron Main");
    Musica m3 = new Musica("Hotel California", "Eagles");
    PlayList p1 = new PlayList("Rock");
    p1.Inserir(m1);
    p1.Inserir(m2);
    p1.Inserir(m3);
//    Console.WriteLine(m1);
//    Console.WriteLine(m2);
//    Console.WriteLine(m3);
    Console.WriteLine(p1);
    //p1.MostrarMusicas();
    foreach(Musica m in p1.Listar())
      Console.WriteLine(m);
  }
}

class PlayList {
  private string nome;
  private Musica[] musicas = new Musica[2];
  private int k;
  public PlayList(string nome) {
    this.nome = nome;
  }
  public void Inserir(Musica m) {
    if (k == musicas.Length) Array.Resize(ref musicas, 2 * musicas.Length);
    musicas[k] = m;    
    k++;
  }
  public void MostrarMusicas() {
    foreach(Musica m in musicas)
      Console.WriteLine(m);
  }
  public Musica[] Listar() {
    Musica[] v = new Musica[k];
    Array.Copy(musicas, v, k);
    return v;
    //return musicas;
  }
  public override string ToString() {
    return $"{nome} - {k}/{musicas.Length} músicas";
  }
}

class Musica {
  private string titulo;
  private string artista;
  public Musica(string titulo, string artista) {
    this.titulo = titulo;
    this.artista = artista;
  }
  public override string ToString() {
    return $"{titulo} - {artista}";
  }
}

