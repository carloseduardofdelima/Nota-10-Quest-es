using System;

class BancaOrganizadora {
  private int id;
  private string nome;
  public BancaOrganizadora(int id, string nome) {
    this.id = id;
    this.nome = nome;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetNome(string nome) {
    this.nome = nome;
  }
  public int GetId() {
    return id;
  }
  public string GetNome() {
    return nome;
  }

  public override string ToString() {
    return id + " " + nome;
  }

}