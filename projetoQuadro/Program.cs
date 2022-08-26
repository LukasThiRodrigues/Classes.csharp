Tela tela = new Tela();
int op;
List<string> opcoes = new List<string>();
opcoes.Add("1- Cadastro de clientes"    );
opcoes.Add("2- Cadastro de contas"      );
opcoes.Add("3- Cadastro de movimentação");
opcoes.Add("4- Ver extrato de conta"    );
opcoes.Add("0- Sair do sistema"         );

tela.prepararTela("(☞ﾟヮﾟ)☞ Banco Luska CIA ☜(ﾟヮﾟ☜)");
op = tela.mostrarMenu(3,2,opcoes);

if (op==0) Console.Write("Até mais seu otário");


Console.ReadKey();