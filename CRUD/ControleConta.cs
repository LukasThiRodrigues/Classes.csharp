class ControleConta{
    // atributos
    Tela tela;
    List<Conta> bancoDados = new List<Conta>();
    
    string nomeAnime;
    int posicao;
    string numId;
    string criadorAnime;
    int numEmps;

    // métodos
    public ControleConta(Tela t){
        this.tela = t;

        // cria uma primeira conta só pra ter alguma coisa no banco
        bancoDados.Add(new Conta("Dragon Ball", "Akira Toriyama ",806));
        bancoDados.Add(new Conta("Naruto", "Masashi Kishimoto",720));
        bancoDados.Add(new Conta("One Piece", "Eiichiro Oda",1035));
    }

    public void executarCRUD(){
        while(true){
            // montar a tela do CRUD de contas
            this.tela.montarMoldura(10,5,70,14);
            this.tela.montarLinhaHor(7,10,70);
            this.tela.centralizar(6,10,65,"Animes");
            this.montarTelaConta();

            //solicita o numero da conta
            Console.SetCursorPosition(21,8);
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
                this.mostrarDadosConta();

                // pergunta para o usuario o que ele deseja fazer

                string resp = this.tela.perguntar(11, 13, "Deseja Alterar, Excluir ou Voltar (A/E/V): ");
                if(resp.ToUpper() == "A"){
                    // o usuário deseja alterar (apenas o nome do titular)
                    this.criadorAnime = this.tela.perguntar(11,12,"Novo titular: ");

                    // perguntar se o usuário confirma alteração
                    this.tela.limparArea(11,13,69,13);
                    resp = this.tela.perguntar(11,13,"Confirma alteração (S/N): ");
                    if (resp.ToUpper() == "S"){
                        this.bancoDados[this.posicao].Criador = this.criadorAnime;
                    }
                } else if (resp.ToUpper() == "E"){

                    // o usuário deseja excluir a conta (a conta e toda a sua movimentacao)
                    this.tela.limparArea(11,13,69,13);
                    resp = this.tela.perguntar(11,13,"Confirma exclusão (S/N): ");
                    if (resp.ToUpper() == "S"){
                        this.bancoDados.RemoveAt(this.posicao);
                    }
                }

            } else{
                /* não achou a conta, mostra a mensagem e 
                pergunta se deseja cadastrar uma nova conta */
                string resp = this.tela.perguntar(11,13, "Anime não encontrado, deseja cadastrar? (S/N): ");
                if(resp.ToUpper() == "S"){
                    this.nomeAnime = this.tela.perguntar(21,9,"");
                    this.criadorAnime = this.tela.perguntar(21,10,"");
                    this.numEmps  = Convert.ToInt32(this.tela.perguntar(21,11,""));

                    this.tela.limparArea(11,13,69,13);
                    resp = this.tela.perguntar(11,13,"Confirma cadastro (S/N): ");
                    if (resp.ToUpper() == "S"){
                        this.bancoDados.Add(
                            new Conta(this.nomeAnime ,this.criadorAnime, this.numEmps)
                        );
                    }
                }
            }
        }
    }

    public void montarTelaConta(){
        Console.SetCursorPosition(11,8);
        Console.Write("Id      :");
        Console.SetCursorPosition(11,9);
        Console.Write("Nome    :");
        Console.SetCursorPosition(11,10);
        Console.Write("Criador :");
        Console.SetCursorPosition(11,11);
        Console.Write("Num Eps :");
    }

    public void mostrarDadosConta(){
        Console.SetCursorPosition(21,10);
        Console.Write(this.bancoDados[this.posicao].Criador);
        Console.SetCursorPosition(21,11);
        Console.Write(this.bancoDados[this.posicao].numeps);
    }
}