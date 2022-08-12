// cria dois objetos do tipo cidade
Cidade cid1 = new Cidade();
Cidade cid2 = new Cidade();

// coloca informações sobre cada cidade nos respectivos objetos
cid1.nome = "Joinville";
cid1.Habitantes = 600000;

cid2.nome = "Curitiba";
cid2.Habitantes = 1200000;

// faz cada objeto mostrar seus dados
Console.WriteLine( cid1.mostrarDados() );
Console.WriteLine( cid2.mostrarDados() );