class Tela{
    // propriedades
    private int corFundo;
    private int corFonte;

    // métodos
    public Tela(){
        this.corFundo = 0;
        this.corFonte = 15;
    }


    public void prepararTela(){
        int lin;
        int col;

        Console.Clear();
        for(lin=0; lin<=24; lin++){
            Console.SetCursorPosition(0,lin);
            Console.Write("|");
            Console.SetCursorPosition(79,lin);
            Console.Write("|");
        }

        for(col=0; col<=79; col++){
            Console.SetCursorPosition(col,0);
            Console.Write("-");
            Console.SetCursorPosition(col,24);
            Console.Write("-");
        }

        Console.SetCursorPosition(0,0); Console.Write("+");
        Console.SetCursorPosition(0,24); Console.Write("+");
        Console.SetCursorPosition(79,0); Console.Write("+");
        Console.SetCursorPosition(79,24); Console.Write("+");
    }
}