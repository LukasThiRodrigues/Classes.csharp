class ControleFunc{
    // atributos
    Tela tela;
    List<Animes> bancoDados = new List<Animes>();
    
    string nomeAnime;
    int posicao;
    string numId;
    string criadorAnime;
    string numEmps;
    string faixaEtaria;
    string genero;

    // métodos
    public ControleFunc(Tela t){
        this.tela = t;

        bancoDados.Add(new Animes("Dragon Ball", "Akira Toriyama ", "12","Aventura, comédia, artes marciais", "806"));
        bancoDados.Add(new Animes("Naruto", "Masashi Kishimoto", "14", "Ação, Comédia, Drama, Aventura", "720"));
        bancoDados.Add(new Animes("One Piece", "Eiichiro Oda", "14", "Ação, aventura, Fantasia", "1035"));
        bancoDados.Add(new Animes("Bleach", "Tite Kubo", "16", "Ação, Aventura, Fantasia, Comédia dramática", "366"));
    }

    public void executarLista(){
            this.tela.montarMolduraLista(18,2,56,13);
            this.tela.montarLinhaHorLista(4,18,56);
            this.tela.centralizar(3,15,56,"Lista");
            this.montarLista();
            Console.ReadKey();
    }

    public void executarINFOS(){
        while(true){
            this.tela.montarMolduraInfo(56,2,119,13);
            this.tela.montarLinhaHorInfos(4,56,119);
            this.tela.centralizar(3,51,119,"Animes");
            this.montarTelaInfos();
            Console.SetCursorPosition(72,5);
            this.numId = Console.ReadLine();
            
            if(this.numId == "") break;
            bool achou = false;
            for(int x=0; x<this.bancoDados.Count; x++){
                if(this.bancoDados[x].id == this.numId){
                    achou = true;
                    this.posicao = x;
                    break;
                }
            }

            if(achou){
                this.mostrarInfosAnimes();
                string resp = this.tela.perguntar(57, 12, "Deseja Atualizar ou Voltar? (A/V): ");
                if(resp.ToUpper() == "A"){
                    this.numEmps = this.tela.perguntar(57,11,"Número de episódios: ");
                    this.tela.limparArea(57,12,118,12);
                    resp = this.tela.perguntar(57,12,"Confirmar alteração? (S/N): ");
                    if (resp.ToUpper() == "S"){
                        this.bancoDados[this.posicao].numeps = this.numEmps;
                    }
                } 
            } else{
                string resp = this.tela.perguntar(57,12, "Anime não encontrado, deseja cadastrar? (S/N): ");
                if(resp.ToUpper() == "S"){
                    this.nomeAnime = this.tela.perguntar(72,6,"");
                    this.criadorAnime = this.tela.perguntar(72,7,"");
                    this.faixaEtaria = this.tela.perguntar(72,8,"");
                    this.genero = this.tela.perguntar(72,9,"");
                    this.numEmps  = this.tela.perguntar(72,10,"");

                    this.tela.limparArea(57,11,118,11);
                    resp = this.tela.perguntar(57,11,"Confirmar cadastro? (S/N): ");
                    if (resp.ToUpper() == "S"){
                        this.addAnime();
                    }
                }
            }
        }
    }

    public void addAnime(){
        this.bancoDados.Add(new Animes(this.nomeAnime ,this.criadorAnime, this.faixaEtaria, this.genero, this.numEmps));
    }

    public void montarTelaInfos(){
        Console.SetCursorPosition(57,5);
        Console.Write("Id           :");
        Console.SetCursorPosition(57,6);
        Console.Write("Nome         :");
        Console.SetCursorPosition(57,7);
        Console.Write("Criador      :");
        Console.SetCursorPosition(57,8);
        Console.Write("Faixa etária :");
        Console.SetCursorPosition(57,9);
        Console.Write("Gênero       :");
        Console.SetCursorPosition(57,10);
        Console.Write("Número Eps   :");
    }

    public void mostrarInfosAnimes(){
        Console.SetCursorPosition(72,6);
        Console.Write(this.bancoDados[this.posicao].nomeAnime);
        Console.SetCursorPosition(72,7);
        Console.Write(this.bancoDados[this.posicao].Criador);
        Console.SetCursorPosition(72,8);
        Console.Write(this.bancoDados[this.posicao].faixaEtaria);
        Console.SetCursorPosition(72,9);
        Console.Write(this.bancoDados[this.posicao].genero);
        Console.SetCursorPosition(72,10);
        Console.Write(this.bancoDados[this.posicao].numeps);
    }

    public void montarLista(){
        for(int i = 0; i < Animes.qtdAnimes; i++){
            for(int pos = 5; pos < 5 + Animes.qtdAnimes; pos++ ){
                Console.SetCursorPosition(19,pos);
                Console.Write(this.bancoDados[i].id + " - " + this.bancoDados[i].nomeAnime);
                i += 1;
            }
        }
    }
}