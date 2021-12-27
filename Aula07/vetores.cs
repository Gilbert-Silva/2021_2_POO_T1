using System;

class Program {
  public static void Main() {
    int[] v = new int[10] { 63, 78, 3, 1, 9, 10, 18, 52, 90, 4};
    int[] w = new int[15];
    //Array.Copy(v, w, 5);
    v.CopyTo(w, 5);
    int[] z;
    z = (int[]) w.Clone();
    Console.WriteLine(z);
    // int v[10];
    // int *v;  malloc = new
    foreach (int x in w)
      Console.WriteLine(x);    

    Console.WriteLine(v[0]);
    Console.WriteLine(v[9]);

    Console.WriteLine(v.Length);

    Array.Reverse(v);
    Array.Sort(v);
    foreach (int x in v)
      Console.WriteLine(x);
    Array.Sort(v);
    foreach (int x in v)
      Console.WriteLine(x);
 
    //string w = "Teste";

    string[] vs = { "C#", "Java", "Python", "Assembly" }; 
    foreach (string s in vs)
      Console.WriteLine(s);

    for (int i = 0; i < vs.Length; i++)  
      Console.WriteLine(vs[i]);

    Array.Resize(ref vs, 6);
    vs[4] = "Visual Basic";
    vs[5] = "JAvascript";
    for (int i = 0; i < vs.Length; i++)  
      Console.WriteLine(vs[i]);

    object[] objs = { 1, "Python", 2.5, false };

    objs[0] = vs;  

    foreach (object obj in objs)
      Console.WriteLine($"{obj} {obj.GetType()}");

    int p = Array.IndexOf(vs, "Pascal");
    Console.WriteLine(p);
    p = Array.IndexOf(vs, "Java");
    Console.WriteLine(p);
    


    // x = []

  }
}