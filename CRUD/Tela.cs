class Tela
{
    ConsoleColor corTexto, corFundo;

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
        this.montarMolduraMenu(0, 0, 119, 13);
        this.montarLinhaHor(2, 0, 119);
        this.centralizar(1, 0, 100, "Lista de Animes");
        this.montarMolduraLista(18,2,56,13);
        this.montarLinhaHorLista(4,18,56);
        this.centralizar(3,15,56,"Lista");
        this.montarMolduraInfo(56,2,119,13);
        this.montarLinhaHorInfos(4,56,119);
        this.centralizar(3,51,119,"Animes");
    }


    public void montarMolduraMenu(int ci, int li, int cf, int lf)
    {
        int col, lin;

        this.limparArea(ci, li, cf, lf);

        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, li);
            Console.Write("─");
            Console.SetCursorPosition(col, lf);
            Console.Write("─");
        }

        for (lin = li; lin <= lf; lin++)
        {
            Console.SetCursorPosition(ci, lin);
            Console.Write("│");
            Console.SetCursorPosition(cf, lin);
            Console.Write("│");
        }

        Console.SetCursorPosition(ci, li); Console.Write("┌");
        Console.SetCursorPosition(ci, lf); Console.Write("└");
        Console.SetCursorPosition(cf, li); Console.Write("┐");
        Console.SetCursorPosition(cf, lf); Console.Write("┘");
    }

    public void montarMolduraOpcoes(int ci, int li, int cf, int lf)
    {
        int col, lin;

        this.limparArea(ci, li, cf, lf);

        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, li);
            Console.Write("─");
            Console.SetCursorPosition(col, lf);
            Console.Write("─");
        }

        for (lin = li; lin <= lf; lin++)
        {
            Console.SetCursorPosition(ci, lin);
            Console.Write("│");
            Console.SetCursorPosition(cf, lin);
            Console.Write("│");
        }

        Console.SetCursorPosition(ci, li); Console.Write("├");
        Console.SetCursorPosition(ci, lf); Console.Write("└");
        Console.SetCursorPosition(cf, li); Console.Write("┬");
        Console.SetCursorPosition(cf, lf); Console.Write("┴");
    }

    public void montarMolduraLista(int ci, int li, int cf, int lf)
    {
        int col, lin;

        this.limparArea(ci, li, cf, lf);

        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, li);
            Console.Write("─");
            Console.SetCursorPosition(col, lf);
            Console.Write("─");
        }

        for (lin = li; lin <= lf; lin++)
        {
            Console.SetCursorPosition(ci, lin);
            Console.Write("│");
            Console.SetCursorPosition(cf, lin);
            Console.Write("│");
        }

        Console.SetCursorPosition(ci, li); Console.Write("┬");
        Console.SetCursorPosition(ci, lf); Console.Write("┴");
        Console.SetCursorPosition(cf, li); Console.Write("┬");
        Console.SetCursorPosition(cf, lf); Console.Write("┴");
    }

    public void montarMolduraInfo(int ci, int li, int cf, int lf)
    {
        int col, lin;

        this.limparArea(ci, li, cf, lf);

        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, li);
            Console.Write("─");
            Console.SetCursorPosition(col, lf);
            Console.Write("─");
        }

        for (lin = li; lin <= lf; lin++)
        {
            Console.SetCursorPosition(ci, lin);
            Console.Write("│");
            Console.SetCursorPosition(cf, lin);
            Console.Write("│");
        }

        Console.SetCursorPosition(ci, li); Console.Write("┬");
        Console.SetCursorPosition(ci, lf); Console.Write("┴");
        Console.SetCursorPosition(cf, li); Console.Write("┤");
        Console.SetCursorPosition(cf, lf); Console.Write("┘");
    }


    public void limparArea(int ci, int li, int cf, int lf)
    {
        int col, lin;
        for (col = ci; col <= cf; col++){
            for (lin = li; lin <= lf; lin++){
                Console.SetCursorPosition(col, lin);
                Console.Write(" ");
            }
        }
    }


    public void montarLinhaHor(int lin, int ci, int cf)
    {
        int col;
        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, lin);
            Console.Write("─");
        }
        Console.SetCursorPosition(ci, lin);
        Console.Write("├");
        Console.SetCursorPosition(cf, lin);
        Console.Write("┼");
    }

    public void montarLinhaHorLista(int lin, int ci, int cf)
    {
        int col;
        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, lin);
            Console.Write("─");
        }
        Console.SetCursorPosition(ci, lin);
        Console.Write("┼");
        Console.SetCursorPosition(cf, lin);
        Console.Write("┼");
    }

    public void montarLinhaHorInfos(int lin, int ci, int cf)
    {
        int col;
        for (col = ci; col <= cf; col++)
        {
            Console.SetCursorPosition(col, lin);
            Console.Write("─");
        }
        Console.SetCursorPosition(ci, lin);
        Console.Write("┼");
        Console.SetCursorPosition(cf, lin);
        Console.Write("┤");
    }

    public void centralizar(int lin, int ci, int cf, string msg)
    {
        int col;
        col = ci+((cf-ci)/2);
        Console.SetCursorPosition(col,lin);
        Console.Write(msg);
    }

    public string mostrarMenu(List<string> menu, int ci, int li){
        int cf, lf, x;
        string op;

        cf = ci + menu[0].Length + 1;
        lf = li + menu.Count() + 6;

        this.montarMolduraOpcoes(ci,li,cf,lf);
        this.montarLinhaHor(4,0,18);

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