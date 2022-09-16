class Conta {
    // Propriedades estáticas
    public static int qtdContasCriadas = 0;
    public static int numeroProximaConta = 1001;

    public List<Transacao> transacoes = new List<Transacao>();
    public string numero;
    public string titular;
    public decimal saldo{
        get{
            decimal resultado = 0;
            foreach(Transacao item in transacoes){
                resultado += item.valor;
            }
            return resultado;
        }
    }

    public Conta(string titular, decimal depInicial){
        this.titular = titular;
        this.numero = numeroProximaConta.ToString();
        this.fazerDeposito(depInicial,DateTime.Now,"Deposito inicial");
        numeroProximaConta ++;
        qtdContasCriadas ++;
    }

    public string mostrarDados(){
        string info="";

        info += "Conta numero ";
        info += this.numero;
        info += " de ";
        info += this.titular;
        info += ", com saldo de ";
        info += this.saldo.ToString();
        info += " reais.";

        return info;
    }

    public void fazerDeposito(decimal val, DateTime dat, string desc){
        this.transacoes.Add(new Transacao(val,dat,desc));
        /* ou
        Transacao deposito = new Transacao(val,dat,desc);
        this.transacoes.Add(deposito);
        */
    }

    public void fazerRetirada(decimal val, DateTime dat, string desc){
        this.transacoes.Add(new Transacao(-val,dat,desc));
    }

}