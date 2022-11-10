<<<<<<< HEAD
class ContaPoupanca : Conta
{
    // ganha 2% de juros ao fim do mês, com base no saldo da conta


    public ContaPoupanca(string tit, decimal val) : base(tit,val)
    {
    }



    public override void fecharMes() 
    {
        decimal jurosGanhos=0;
        if ( this.saldo > 0 )
        {
            jurosGanhos = this.saldo * 0.02m;
            this.fazerDeposito(jurosGanhos,DateTime.Now,"Juros de poupança");
        }
    }
=======
class ContaPoupanca : Conta
{
    // ganha 2% de juros ao fim do mês, com base no saldo da conta


    public ContaPoupanca(string tit, decimal val) : base(tit,val)
    {
    }



    public override void fecharMes() 
    {
        decimal jurosGanhos=0;
        if ( this.saldo > 0 )
        {
            jurosGanhos = this.saldo * 0.02m;
            this.fazerDeposito(jurosGanhos,DateTime.Now,"Juros de poupança");
        }
    }
>>>>>>> 559c4ba3f64eced17236bfe528565723d883593d
}