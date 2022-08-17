// cria dois objetos do tipo cidade
Cidade cid1 = new Cidade();
Cidade cid2 = new Cidade();
Cidade cid3 = new Cidade();

// coloca informações sobre cada cidade nos respectivos objetos
cid1.nome = "Joinville";
cid1.Habitantes = 600000;

cid2.nome = "Curitiba";
cid2.Habitantes = 1200000;

cid3.nome = "Jaraguá";
cid3.Habitantes = 500000;

// faz cada objeto mostrar seus dados
Console.Clear();
Console.WriteLine( cid1.mostrarDados() );
Console.WriteLine( cid2.mostrarDados() );
Console.WriteLine( cid3.mostrarDados() );

//-------------------------------------------------------------

correntista crr1 = new correntista();
correntista crr2 = new correntista();

crr1.cpf = "141.025.527-78";
crr1.nome = "Jetosbasdo";
crr1.telefone = "+55 (47) 98413-5633";

crr2.cpf = "091.245.678-90";
crr2.nome = "Roger klaus";
crr2.telefone = "+55 (47) 99999-5490";

Console.Clear();
Console.WriteLine( crr1.mostrarDados() );
Console.WriteLine( crr2.mostrarDados() );