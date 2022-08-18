class Cidade{
    // propriedades
    private string nome;
    private int Habitantes;
    private double area;
    
    // métodos
    public Cidade( string n, int h=0){ // Assinatura do método
        this.nome = n;
        this.Habitantes = h;
    }

    public Cidade(){ // Assinatura do método
        this.nome = "Sem nome";
        this.Habitantes = 0;
    }

    public string mostrarDados(){ // Assinatura do método
        string mensagem;
            mensagem = "A cidade de " + this.nome + " possui " + 
            Convert.ToString(this.Habitantes) + " habitantes";
        return mensagem;
    }

    public string mostrarDados(string oque){ // Assinatura do método
        
        string mensagem;

        mensagem = " O nome da cidade é: " + this.nome + ".";

        if (oque=="T" || oque=="H"){
            mensagem += "\n Vivem nesta cidade " +
                Convert.ToString(this.Habitantes) +
                " habitantes.";
        }

        if (oque=="T" || oque=="A"){
            mensagem += "\n A cidade possui uma área de " + Convert.ToString(area) + "km2.";
        }

        return mensagem;
    }

    public bool definirArea(double a){
        bool deuCerto = true;

        if (this.verificarDensidade(a) < 1){
            deuCerto = false;
        } else {
            this.area = a;
        }

        return deuCerto; 
     
    }

    private double verificarDensidade(double a){
        double d;
        d = Habitantes/a;
        return d;
    }
}