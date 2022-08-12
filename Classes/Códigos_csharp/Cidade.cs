class Cidade{
    // propriedades
    public string nome;
    public int Habitantes;
    
    // métodos
    public string mostrarDados(){
        string mensagem;
            mensagem = "A cidade de " + this.nome + " possui " + 
            Convert.ToString(this.Habitantes) + " habitantes";
        return mensagem;
    }
}