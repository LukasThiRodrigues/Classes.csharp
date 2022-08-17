class Cidade{
    // propriedades
    public string nome;
    public int Habitantes;
    
    // métodos
    public Cidade( string n, int h){
        this.nome = n;
        this.Habitantes = h;
    }

    public Cidade(){
        this.nome = "Sem nome";
        this.Habitantes = 0;
    }

    public string mostrarDados(){
        string mensagem;
            mensagem = "A cidade de " + this.nome + " possui " + 
            Convert.ToString(this.Habitantes) + " habitantes";
        return mensagem;
    }
}