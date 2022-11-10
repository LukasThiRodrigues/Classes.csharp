class CRUD{
    // atributos
    Alvos alvo;
    List<Alvos> vitimas = new List<Alvos>();
    int posicao;
    Tela tela;

    // construtor
    public CRUD(Tela t){
        this.tela = t;
                
    }

    // outros métodos
    public void executarCRUD(){
        while(true){
            // mostra tela
            // pergunta codigo
            // procura codigo
            // se achou codigo
            //      mostra os dados do registo
            //      pergunta se deseja A/E
            //      se deseja ALTERAR
            //          pergunta novos dados
            //          pede para confirmar novos dados
            //          se confirmado
            //              grava os novos dados
            //      se deseja EXCLUIR
            //          pede para confirmar exclusão
            //          se confirmado
            //              exclui o registro
            // se não achou codigo
            //      informa que não encontrou
            //      pergunta se deseja cadastrar
            //      se confirmado
            //          pergunta dados do registro
            //          pergunta se confirma registro
            //          se confirmado
            //              cadastra novo registro
        }
    }
}