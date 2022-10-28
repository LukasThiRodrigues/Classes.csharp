Tela tela = new Tela();
ControleConta contas = new ControleConta(tela);

string opcao;
List<string> menuPrincipal = new List<string>();

menuPrincipal.Add("1 - Lista        ");
menuPrincipal.Add("2 - Pesquisar    ");
menuPrincipal.Add("3 - Favoritos    ");
menuPrincipal.Add("0 - Sair         ");

tela.configurarTela();

while(true){
    tela.montarTelaSistema();
    opcao = tela.mostrarMenu(menuPrincipal,3,3);

    if(opcao == "0") break;
    if(opcao == "2") contas.executarCRUD();
}

//tela.montarMoldura(5,5,40,10);
//tela.montarMoldura(10,7,50,20);

Console.Clear();