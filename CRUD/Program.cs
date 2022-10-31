Tela tela = new Tela();
Controle anime = new Controle(tela);

string opcao;
List<string> menuPrincipal = new List<string>();

menuPrincipal.Add("     Opções      ");
menuPrincipal.Add("-----------------");
menuPrincipal.Add("1 - Lista        ");
menuPrincipal.Add("2 - Informações  ");
menuPrincipal.Add("0 - Sair         ");


tela.configurarTela();


while(true){
    tela.montarTelaSistema();
    opcao = tela.mostrarMenu(menuPrincipal,0,2);

    if(opcao == "0") break;
    if(opcao == "1") anime.executarLista();
    if(opcao == "2") anime.executarINFOS();
}


Console.Clear();