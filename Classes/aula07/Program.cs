Console.Clear();
Conta contaXunda = new Conta("Xunda",400);
contaXunda.fazerDeposito(5.50m,DateTime.Now,"Pix da coca-cola");
contaXunda.fazerRetirada(200,DateTime.Now,"Churrasco no fds");
contaXunda.fazerRetirada(105.50m,DateTime.Now,"Conta de luz");
Console.WriteLine(contaXunda.mostrarDados());
Console.ReadKey();
Console.WriteLine();

Conta contaCatatau = new Conta("Catatau",100);
contaCatatau.fazerDeposito(500, DateTime.Now, "Jogo do bixo");
contaCatatau.fazerRetirada(250, DateTime.Now, "Agiota");
contaCatatau.fazerRetirada(55, DateTime.Now, "Only fans");
Console.WriteLine(contaCatatau.mostrarDados());
Console.ReadKey();
Console.WriteLine();

Conta contaZe = new Conta("Ze Colmeia",180);
Console.WriteLine(contaZe.mostrarDados());
Console.ReadKey();
Console.WriteLine();

Console.WriteLine("----------------------------------");
Console.WriteLine("Contas criadas: " + Conta.qtdContasCriadas);
Console.WriteLine("Proxima conta: " + Conta.numeroProximaConta);
Console.WriteLine();