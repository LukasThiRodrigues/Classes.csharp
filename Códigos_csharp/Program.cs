Cidade c1 = new Cidade("Joinville", 900);
Cidade c2 = new Cidade();
Cidade c3 = new Cidade("Jaraguá");

Console.Clear();

if (c1.definirArea(1000)){
    Console.WriteLine("Área definida com sucesso");
} else{
    Console.WriteLine("Erro! Área muito grande ou população muito pequena");
}
Console.WriteLine();

Console.WriteLine( c1.mostrarDados() ); // Chamada de método
Console.WriteLine();
Console.WriteLine( c1.mostrarDados("H") ); // Chamada de método
Console.WriteLine();
Console.WriteLine( c1.mostrarDados("A") ); // Chamada de método
Console.WriteLine();
Console.WriteLine( c1.mostrarDados("T") ); // Chamada de método

/*
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
*/
