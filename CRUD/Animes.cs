class Animes
{
    public static int qtdAnimes = 0;
    public static int numeroProximoAnime = 1;    
    public string id;
    public string nomeAnime; 
    public string Criador;
    public string faixaEtaria;
    public string genero;
    public string numeps;

    public Animes(string nomeAnime, string criador, string faxEt, string gen, string numEps)
    {
        this.nomeAnime = nomeAnime;
        this.Criador = criador;
        this.faixaEtaria = faxEt;
        this.genero = gen;
        this.numeps = numEps;
        this.id  = numeroProximoAnime.ToString();
        
        numeroProximoAnime ++;
        qtdAnimes ++;
    }

}