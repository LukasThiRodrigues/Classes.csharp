class Controle{
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
    public Controle(Tela t){
        this.tela = t;

        // cria uma primeira conta só pra ter alguma coisa no banco
        bancoDados.Add(new Animes("Dragon Ball", "Akira Toriyama ", "12","Aventura, comédia, artes marciais", "806"));
        bancoDados.Add(new Animes("Naruto", "Masashi Kishimoto", "14", "Ação, Comédia, Drama, Aventura", "720"));
        bancoDados.Add(new Animes("One Piece", "Eiichiro Oda", "14", "Ação, aventura, Fantasia", "1035"));
    }

    public void executarLista(){
            this.tela.montarMoldura(40,5, 0,70,20);
            this.tela.montarLinhaHor(7,40,70);
            this.tela.centralizar(6,42,65,"Lista");
            this.montarLista();
            Console.ReadKey();
    }

    public void executarINFOS(){
        while(true){
            // montar a tela do CRUD de contas
            this.tela.montarMoldura(10,5,0,70,16);
            this.tela.montarLinhaHor(7,10,70);
            this.tela.centralizar(6,10,65,"Animes");
            this.montarTelaConta();

            //solicita o numero da conta
            Console.SetCursorPosition(26,8);
            this.numId = Console.ReadLine();
            if(this.numId == "") break;

            // procura no banco de dados se existe o nome do anime
            bool achou = false;
            for(int x=0; x<this.bancoDados.Count; x++){
                if(this.bancoDados[x].id == this.numId){
                    achou = true;
                    this.posicao = x;
                    break;
                }
            }

            /* mostra os dados da conta, caso tenha encontrado ou 
            mostra a mensagem de conta não encontrada */
            if(achou){
                // achou a conta e vai mostrar os dados
                this.mostrarInfosAnimes();

                // pergunta para o usuario o que ele deseja fazer

                string resp = this.tela.perguntar(11, 15, "Deseja Atualizar ou Voltar (A/V): ");
                if(resp.ToUpper() == "A"){
                    // o usuário deseja alterar (apenas o nome do titular)
                    this.numEmps = this.tela.perguntar(11,14,"Número de episódios: ");

                    // perguntar se o usuário confirma alteração
                    this.tela.limparArea(11,15,69,15);
                    resp = this.tela.perguntar(11,15,"Confirma alteração (S/N): ");
                    if (resp.ToUpper() == "S"){
                        this.bancoDados[this.posicao].numeps = this.numEmps;
                    }
                } 
            } else{
                /* não achou a conta, mostra a mensagem e 
                pergunta se deseja cadastrar uma nova conta */
                string resp = this.tela.perguntar(11,15, "Anime não encontrado, deseja cadastrar? (S/N): ");
                if(resp.ToUpper() == "S"){
                    this.nomeAnime = this.tela.perguntar(26,9,"");
                    this.criadorAnime = this.tela.perguntar(26,10,"");
                    this.faixaEtaria = this.tela.perguntar(26,11,"");
                    this.genero = this.tela.perguntar(26,12,"");
                    this.numEmps  = this.tela.perguntar(26,13,"");

                    this.tela.limparArea(11,15,69,15);
                    resp = this.tela.perguntar(11,15,"Confirma cadastro (S/N): ");
                    if (resp.ToUpper() == "S"){
                        this.addDados();
                    }
                }
            }
        }
    }

    public void addDados(){
        this.bancoDados.Add(new Animes(this.nomeAnime ,this.criadorAnime, this.faixaEtaria, this.genero, this.numEmps));
    }

    public void montarTelaConta(){
        Console.SetCursorPosition(11,8);
        Console.Write("Id           :");
        Console.SetCursorPosition(11,9);
        Console.Write("Nome         :");
        Console.SetCursorPosition(11,10);
        Console.Write("Criador      :");
        Console.SetCursorPosition(11,11);
        Console.Write("Faixa etária :");
        Console.SetCursorPosition(11,12);
        Console.Write("Gênero       :");
        Console.SetCursorPosition(11,13);
        Console.Write("Número Eps   :");
    }

    public void mostrarInfosAnimes(){
        Console.SetCursorPosition(26,9);
        Console.Write(this.bancoDados[this.posicao].nomeAnime);
        Console.SetCursorPosition(26,10);
        Console.Write(this.bancoDados[this.posicao].Criador);
        Console.SetCursorPosition(26,11);
        Console.Write(this.bancoDados[this.posicao].faixaEtaria);
        Console.SetCursorPosition(26,12);
        Console.Write(this.bancoDados[this.posicao].genero);
        Console.SetCursorPosition(26,13);
        Console.Write(this.bancoDados[this.posicao].numeps);
    }

    public void montarLista(){
        for(int i = 0; i < Animes.qtdAnimes; i++){
            for(int pos = 8; pos < 8 + Animes.qtdAnimes; pos++ ){
                Console.SetCursorPosition(41,pos);
                Console.Write(this.bancoDados[i].id + " - " + this.bancoDados[i].nomeAnime);
                i += 1;
            }
        }
    }
}