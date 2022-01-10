using System;

class MainClass {
  public static void Main (string[] args) {
    BancaOrganizadora Banca01 = new BancaOrganizadora(1, "Banca-01");
    BancaOrganizadora Banca02 = new BancaOrganizadora(2, "Banca-02");
    Console.WriteLine(Banca01);
    Console.WriteLine(Banca02);

    Questão q1 = new Questão(1, "Questão 01", new string[4] { "a", "b", "c", "d" },  Banca01);
    Questão q2 = new Questão(2, "Questão 02", new string[4] { "a", "b", "c", "d" }, Banca02);
    Questão q3 = new Questão(3, "Questão 03", new string[4] { "a", "b", "c", "d" }, Banca01);
    Console.WriteLine(q1);
    Console.WriteLine(q2);
    Console.WriteLine(q3);
    
  }
}



