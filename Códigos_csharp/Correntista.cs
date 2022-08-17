class correntista{
    public string cpf;
    public string nome;
    public string telefone;

    public string mostrarDados(){
        string apresentar;
            apresentar = "O correntista " + this.nome + " possui o cpf " +
            this.cpf + " e o numero de telefone e " +
            this.telefone;
        return apresentar; 
    }
}