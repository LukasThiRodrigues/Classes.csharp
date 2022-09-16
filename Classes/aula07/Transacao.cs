class Transacao{
    public decimal valor;
    public DateTime data;
    public string descricao;

    public Transacao(decimal val, DateTime dat, string desc){
        this.valor = val;
        this.data = dat;
        this.descricao = desc;
    }
}