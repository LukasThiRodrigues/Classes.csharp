class Tela
{
    // propriedades
    ConsoleColor corTexto, corFundo;


    // construtor
    public Tela(ConsoleColor ct = ConsoleColor.Cyan,
                ConsoleColor cf = ConsoleColor.Black)
    {
        this.corFundo = cf;
        this.corTexto = ct;

        this.configurarTela();
    }


    public void configurarTela()
    {
        Console.BackgroundColor = this.corFundo;
        Console.ForegroundColor = this.corTexto;
        Console.Clear();
    }


    public void montarTelaSistema()
    {
        this.montarMoldura(0, 0, 0, 119, 28);
        this.montarLinhaHor(2, 0, 119);
        this.centralizar(1, 0, 100, "Lista de Animes");
    }


    public void montarMoldura(int ci, int li, int cm, int cf, int lf)
    {
        int col, lin;

        // limpa a area em que será montada a moldura
        this.limparArea(ci, li, cf, lf);

        // desenha as linhas horizontais
        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, li);
            Console.Write("-");
            Console.SetCursorPosition(col, lf);
            Console.Write("-");
        }

        // desenha as linhas verticais
        for (lin = li; lin <= lf; lin++)
        {
            Console.SetCursorPosition(ci, lin);
            Console.Write("|");
            Console.SetCursorPosition(cf, lin);
            Console.Write("|");
            Console.SetCursorPosition(cm, lin);
            Console.Write("|");
        }

        // desenha os cantos da moldura
        Console.SetCursorPosition(ci, li); Console.Write("+");
        Console.SetCursorPosition(ci, lf); Console.Write("+");
        Console.SetCursorPosition(cf, li); Console.Write("+");
        Console.SetCursorPosition(cf, lf); Console.Write("+");
        Console.SetCursorPosition(cm, li); Console.Write("+");
        Console.SetCursorPosition(cm, lf); Console.Write("+");
    }


    public void limparArea(int ci, int li, int cf, int lf)
    {
        int col, lin;
        // para cada coluna
        for (col = ci; col <= cf; col++)
        {
            // em cada uma das linahs
            for (lin = li; lin <= lf; lin++)
            {
                // posiciona
                Console.SetCursorPosition(col, lin);
                // imprime 1 espaço em branco para "limpar"
                Console.Write(" ");
            }
        }
    }


    public void montarLinhaHor(int lin, int ci, int cf)
    {
        int col;
        // traça a linha
        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, lin);
            Console.Write("-");
        }
        // arruma as pontas
        Console.SetCursorPosition(ci, lin);
        Console.Write("+");
        Console.SetCursorPosition(cf, lin);
        Console.Write("+");
    }


    public void centralizar(int lin, int ci, int cf, string msg)
    {
        int col;
        col = ci+((cf-ci)/2);
        Console.SetCursorPosition(col,lin);
        Console.Write(msg);
    }

    public string mostrarMenu(List<string> menu, int ci, int li){
        int cf, lf, cm, x;
        string op;

        // calcula a linha final e a coluna final
        cf = ci + menu[0].Length + 1;
        lf = li + menu.Count() + 21;
        cm = 56;

        // monta a moldura do menu
        this.montarMoldura(ci,li, cm, cf,lf);

        // mostra as opções do menu
        for ( x = 0; x < menu.Count(); x++){
            Console.SetCursorPosition(ci+1, li+x+1);
            Console.Write(menu[x]);
        }
            Console.SetCursorPosition(ci+1, li+x+1);
            Console.Write("Ir Para: ");
            op = Console.ReadLine();
            return op;
    }

    public string perguntar(int col, int lin, string perg){
        string resp = "S";
        Console.SetCursorPosition(col,lin);
        Console.Write(perg);
        resp = Console.ReadLine();
        return resp;
    }
}