using System;
using System.Xml.Serialization;
using System.IO;

class Program {
  public static void Main() {
    /*
    //int.Parse(null);
    string s = "C#";
    try {
      int x = int.Parse(Console.ReadLine());
      int y = int.Parse(Console.ReadLine());
      int z = x / y;
      Console.WriteLine(z);
      Console.WriteLine(s[x]); // 0, 1
      Triangulo t = null;
      // Console.WriteLine(t.CalcArea());
      t = new Triangulo();
      t.SetBase(x);
      t.SetAltura(y);
      Console.WriteLine(t.CalcArea());
    }
    catch (FormatException) {
      Console.WriteLine("O valor informado não é um número");
    }
    catch (OverflowException) {
      Console.WriteLine("O valor informado é muito grande");
    }
    catch (MeuErroException erro) {
      Console.WriteLine($"O valor informado {erro.GetValor()} é inválido");
    }
    /*
    catch {
      
    }
    /*
    catch (Exception) {
      Console.WriteLine("Deu algum erro");
    }
    finally {
      Console.WriteLine("Cheguei nessa linha");
    }
    */
    Triangulo t = new Triangulo();
    t.SetBase(20);
    t.SetAltura(10);
    Console.WriteLine(t.CalcArea());    

    /*
    // Xml
    StreamWriter f = null;
    try {
      XmlSerializer xml = new XmlSerializer(typeof(Triangulo));
      f = new StreamWriter("./triangulo.xml");
      xml.Serialize(f, t);
    }
    finally {
      if (f != null) f.Close();
    }
    */
    // IDisposable
    using (StreamWriter f = new StreamWriter("./triangulo.xml") ) {
      XmlSerializer xml = new XmlSerializer(typeof(Triangulo));
      xml.Serialize(f, t);
    }
  }
}

public class Triangulo {
  private double b, h;
  public double Base {
    get => b;
    set => b = value > 0 ? value : 0; 
  }
  public double Altura {
    get => h;
    set => h = value > 0 ? value : 0; 
  }
  public void SetBase(double v) {
    if(v > 0) b = v;
    else {
      ArgumentOutOfRangeException r = new ArgumentOutOfRangeException();
      throw r;
    }
  }
  public void SetAltura(double v) {
    if(v > 0) h = v;
    else {
      MeuErroException r = new MeuErroException(v);
      throw r;
    }
  }
  public double CalcArea() {
    return b * h / 2;
  }
}

class MeuErroException : Exception {
  private double valor;
  public MeuErroException(double v) {
    valor = v;
  }
  public double GetValor() {
    return valor;
  }
}