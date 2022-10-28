class Conta
{
    // propriedades estáticas
    // fica "armazenada" na classe
    public static int qtdContasCriadas = 0;
    public static int numeroProximaConta = 1;

    // propriedades
    // ficam "armazendas" no objeto criado
    public List<Transacao> transacoes = new List<Transacao>();
    
    public string nome; 
    public string id;
    public string Criador;
    
    public int numeps;





    // métodos virtuais - permite o polimorfismo
    // o método definido aqui, não é implementado na classe mãe
    // mas apenas nas classes filhas
    // em todas as classes filhas, o método possuirá a mesma assinatura
    // mas com código fonte (implementação) diferente
    public virtual void fecharMes() {}






    // método construtor
    public Conta(string nomeAnime, string criador, int numEps)
    {
        this.nome = nomeAnime;
        this.Criador = criador;
        this.id  = numeroProximaConta.ToString();
        
        numeroProximaConta ++;
        qtdContasCriadas ++;
    }


    // outros métodos


    public void fazerDeposito(decimal val, DateTime dat, string desc)
    {
        this.transacoes.Add( new Transacao(val,dat,desc) );
        /* ou
        Transacao deposito = new Transacao(val,dat,desc);
        this.transacoes.Add(deposito)
        */
    }

}