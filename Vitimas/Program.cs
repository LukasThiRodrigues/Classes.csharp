Tela tela = new Tela(ConsoleColor.DarkBlue, ConsoleColor.White);
CRUD crud = new CRUD(tela);

while(true){
    tela.prepararTela();
    tela.escrever(1,1,"Menu");
    tela.escrever(1,2,"1 - Alvos");
    tela.escrever(1,3,"0 - Sair");
    string op = tela.perguntar(1,4,"Opção: ");

    if (op == "0") break;
    if (op == "1") crud.executarCRUD();
}