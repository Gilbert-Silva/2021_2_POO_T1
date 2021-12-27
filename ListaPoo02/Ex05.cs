using System;

class Program {
  public static void Main() {
    Cinema c = new Cinema();
    c.SetDia(3);
    Console.WriteLine(c.ValorIngresso());
    c.SetDia(4);
    Console.WriteLine(c.ValorIngresso());
  }
}

class Cinema {
  private int dia = 1;
  private int hora;
  public void SetDia(int dia) {
    if (dia >= 1 && dia <= 7) this.dia = dia;
  }
  public void SetHora(int hora) {
    if (hora >= 0 && hora <= 23) this.hora = hora;
    
  }
  public double ValorIngresso() {
    double p = 16;
    switch(dia) {
      case 4: p = 8; break;
      case 1:
      case 6:
      case 7: p = 20; break;
    }
    return p;
  }
}