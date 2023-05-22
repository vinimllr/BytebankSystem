using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;
#region

//Diretor roberta = new Diretor("789456123");
//roberta.Nome = "Roberta Souza";

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();


//roberta.ExibirDados();



//GerenciadorDeBonificacao gerenciadorBonificacao = new GerenciadorDeBonificacao();
//GerenciadorPremioSemestral gerenciadorPremioSemestral = new GerenciadorPremioSemestral();
//gerenciadorBonificacao.Registrar(roberta);
//gerenciadorPremioSemestral.Registrar(roberta);


//Console.WriteLine("Total de bonificação: " + gerenciadorBonificacao.TotalDeBonificacao);
//Console.WriteLine("Total de premio Semestral :" + gerenciadorPremioSemestral.TotalPremioSemestral);

//Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);
//roberta.AumentarSalario();
//Console.WriteLine("Salario da roberta pós aumento: " + roberta.Salario);
#endregion


Diretor roberta = new Diretor("041141141");
roberta.Nome = "Roberta";
roberta.Email = "roberta@gmail.com";
roberta.Senha = "123";

GerenteDeContas ursula = new GerenteDeContas("235413549");
ursula.Nome = "Ursula";
ursula.Email = "ursula@gmail.com";
ursula.Senha = "321";

SistemaInterno sistema = new SistemaInterno();

sistema.Logar(ursula, "ursula@gmail.com", "321");
sistema.Logar(roberta,"robera@gmail.com", "123");
