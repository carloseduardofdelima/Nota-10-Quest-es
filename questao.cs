using System;

class Questão {
  private int id;
  private BancaOrganizadora banca;
  private string enunciado;
  private string[] respostas;

  public Questão(int id, string enunciado, string[] respostas) {
    this.id = id;
    this.enunciado = enunciado;
    this.respostas = respostas;
  }

  public Questão(int id, string enunciado, string[] respostas, BancaOrganizadora banca) : this(id, enunciado, respostas) {
    this.banca = banca;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetEnunciado(string enunciado) {
    this.enunciado = enunciado;
  }
  public void SetRespostas(string[] respostas) {
    this.respostas = respostas;
  }
  public void SetBanca(BancaOrganizadora banca) {
    this.banca = banca;
  }
  public int GetId() {
    return id;
  }
  public string GetEnunciado() {
    return enunciado;
  }
  public string[] GetRespostas() {
    return respostas;
  }
  public BancaOrganizadora GetBanca() {
    return banca;
  }

  public override string ToString() {
    if(banca == null) {
      return "Questão: " + id + "\nEnunciado: " + enunciado + "\nAlternativas: \n" + respostas[0] + "\n" + respostas[1] + "\n" + respostas[2] + "\n" + respostas[3];
    }
    else {
      return "Questão: " + id + "\nEnunciado: " + enunciado + "\nAlternativas: \n" + respostas[0] + "\n" + respostas[1] + "\n" + respostas[2] + "\n" + respostas[3] + "\nBanca: " + banca + "\n";
    }
    
    
  }

}