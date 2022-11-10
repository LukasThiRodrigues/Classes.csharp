<<<<<<< HEAD
class ContaEspecial : Conta
{
    // cobra 10% de juros se usar o valor do limite, ou seja,
    // consumir algum valor além do saldo positivo


    public ContaEspecial(string tit, decimal val) : base(tit,val)
    {

    }



    public override void fecharMes() 
    {
        decimal jurosPagos=0;
        if ( this.saldo < 0 )
        {
            jurosPagos = -this.saldo * 0.1m;
            this.fazerRetirada(jurosPagos,DateTime.Now,"Juros de uso do limite");
        }
    }


    public void fazerRetirada(decimal val, DateTime dat, string desc)
    {
        this.transacoes.Add( new Transacao(-val,dat,desc) );
    }

=======
class ContaEspecial : Conta
{
    // cobra 10% de juros se usar o valor do limite, ou seja,
    // consumir algum valor além do saldo positivo


    public ContaEspecial(string tit, decimal val) : base(tit,val)
    {

    }



    public override void fecharMes() 
    {
        decimal jurosPagos=0;
        if ( this.saldo < 0 )
        {
            jurosPagos = -this.saldo * 0.1m;
            this.fazerRetirada(jurosPagos,DateTime.Now,"Juros de uso do limite");
        }
    }


    public void fazerRetirada(decimal val, DateTime dat, string desc)
    {
        this.transacoes.Add( new Transacao(-val,dat,desc) );
    }

>>>>>>> 559c4ba3f64eced17236bfe528565723d883593d
}