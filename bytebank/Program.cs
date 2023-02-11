using bytebank.Contas;
using bytebank.Funcionarios;
using bytebank.Parceria;
using bytebank.SistemaInterno;
using bytebank.Titular;
using bytebank.Utilitario;
using System.Collections.Concurrent;

#region
//Funcionario pedro = new Funcionario("123456789", "Pedro Malazartes", 2000);


//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());


//Diretor roberta = new Diretor("987654321", "Roberta Silva");



//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações" + gerenciador.TotalDeBonificacao);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine($"Novo Salario do Pedro {pedro.Salario} ");
//Console.WriteLine($"Novo Salario da Roberta {roberta.Salario} ");
#endregion

CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("12589654256", "Ulises Peixoto");

    Diretor paula = new Diretor("56986532515", "Paula Silveira");

    Auxiliar igor = new Auxiliar("56898653654", "Igor Meses");

    GerenteDeContas camila = new GerenteDeContas("26956325698", "Camila furtis");

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine($"Total de bonificações {gerenciador.TotalDeBonificacao}");

}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ramon = new Diretor("2563265214", "Ramon Menezes");
    ramon.Senha = "256";

    GerenteDeContas Cassia = new GerenteDeContas("5632665896", "Cássia Martineira");
    Cassia.Senha = "234";


    ParceiroComercial caio = new();
    caio.Senha = "888";

    sistema.Logar(ramon, "256");
    sistema.Logar(Cassia, "456");
    sistema.Logar(caio, "888");
}





