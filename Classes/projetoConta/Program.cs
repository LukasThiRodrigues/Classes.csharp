Console.Clear();

contaPoupanca cpJoao = new contaPoupanca("Joao",1000);
Console.WriteLine(cpJoao.mostrarDados());
Console.WriteLine(cpJoao.recuperarExtrato());
Console.ReadKey();
cpJoao.fazerDeposito(450,DateTime.Now,"Recebimento de freela");
cpJoao.fazerRetirada(25,DateTime.Now,"Rifa escola");
Console.WriteLine(cpJoao.recuperarExtrato());
Console.ReadKey();
cpJoao.fecharMes();
Console.WriteLine(cpJoao.recuperarExtrato());
Console.ReadKey();

Console.Clear();

contaMesada cmEuMesmo = new contaMesada("Lukas",100,100);
Console.WriteLine(cmEuMesmo.mostrarDados());
Console.WriteLine(cmEuMesmo.recuperarExtrato());
Console.ReadKey();
cmEuMesmo.fazerRetirada(50,DateTime.Now,"Cinema");
Console.WriteLine(cmEuMesmo.recuperarExtrato());
Console.ReadKey();
cmEuMesmo.fazerRetirada(25,DateTime.Now,"Lanche");
Console.WriteLine(cmEuMesmo.recuperarExtrato());
Console.ReadKey();
cmEuMesmo.fecharMes();
Console.WriteLine(cmEuMesmo.recuperarExtrato());
Console.ReadKey();

/*
Conta contaXunda = new Conta("Xunda",400);
contaXunda.fazerDeposito(5.50m,DateTime.Now,"Pix da coca-cola");
contaXunda.fazerRetirada(200,DateTime.Now,"Churrasco no fds");
contaXunda.fazerRetirada(105.50m,DateTime.Now,"Conta de luz");
Console.WriteLine(contaXunda.mostrarDados());
Console.WriteLine(contaXunda.recuperarExtrato());
Console.WriteLine();
Console.ReadKey();

Conta contaCatatau = new Conta("Catatau",100);
contaCatatau.fazerDeposito(500, DateTime.Now, "Jogo do bixo");
contaCatatau.fazerRetirada(250, DateTime.Now, "Agiota");
contaCatatau.fazerRetirada(55, DateTime.Now, "Only fans");
Console.WriteLine(contaCatatau.mostrarDados());
Console.WriteLine(contaCatatau.recuperarExtrato());
Console.WriteLine();
Console.ReadKey();

Conta contaZe = new Conta("Ze Colmeia",180);
Console.WriteLine(contaZe.mostrarDados());
Console.WriteLine(contaZe.recuperarExtrato());
Console.WriteLine();
Console.ReadKey();
*/

Console.WriteLine("----------------------------------");
Console.WriteLine("Contas criadas: " + Conta.qtdContasCriadas);
Console.WriteLine("Proxima conta: " + Conta.numeroProximaConta);
Console.WriteLine();
