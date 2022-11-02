Tela tela = new Tela();
ControleFunc anime = new ControleFunc(tela);

string opcao;
List<string> menuPrincipal = new List<string>();

menuPrincipal.Add("     Opções      ");
menuPrincipal.Add("─────────────────");
menuPrincipal.Add("1 - Lista        │ Digite 1 para ver a lista de animes │         Digite 2 para ver as informações dos animes");
menuPrincipal.Add("2 - Informações  │        e o Id correspondente        │                   com base no Id da lista");
menuPrincipal.Add("3 - EasterEgg    ");
menuPrincipal.Add("0 - Sair         ");

tela.configurarTela();


while(true){
    tela.montarTelaSistema();
    opcao = tela.mostrarMenu(menuPrincipal,0,2);

    if(opcao == "0") break;
    if(opcao == "1") anime.executarLista();
    if(opcao == "2") anime.executarINFOS();
    if(opcao == "3") anime.executarEasterEgg();
}


Console.Clear();