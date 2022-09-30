class contaMesada : Conta{

    // um novo depósito automático de valo fixo a cada mês será realizado

    private decimal valorMesada = 0;

    public contaMesada(string tit, decimal val, decimal vlm=100) : base(tit,val){
        this.valorMesada = vlm;
    }

    public override void fecharMes(){
            this.fazerDeposito(this.valorMesada,DateTime.Now,"Depósito de mesada");
        }
}