using bytebank.Contas;
using bytebank.Funcionarios;
using bytebank.Parceria;
using bytebank.SistemaInterno;
using bytebank.Titular;
using bytebank.Utilitario;
using System.Collections.Concurrent;
using System.Net.Http.Headers;


#region
//CalcularBonificacao();
//UsarSistema();

//void CalcularBonificacao()
//{
//    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//    Designer ulisses = new Designer("12589654256", "Ulises Peixoto");

//    Diretor paula = new Diretor("56986532515", "Paula Silveira");

//    Auxiliar igor = new Auxiliar("56898653654", "Igor Meses");

//    GerenteDeContas camila = new GerenteDeContas("26956325698", "Camila furtis");

//    gerenciador.Registrar(ulisses);
//    gerenciador.Registrar(paula);
//    gerenciador.Registrar(igor);
//    gerenciador.Registrar(camila);

//    Console.WriteLine($"Total de bonificações {gerenciador.TotalDeBonificacao}");

//}

//void UsarSistema()
//{
//    SistemaInterno sistema = new SistemaInterno();

//    Diretor ramon = new Diretor("2563265214", "Ramon Menezes");
//    ramon.Senha = "256";

//    GerenteDeContas Cassia = new GerenteDeContas("5632665896", "Cássia Martineira");
//    Cassia.Senha = "234";


//    ParceiroComercial caio = new();
//    caio.Senha = "888";

//    sistema.Logar(ramon, "256");
//    sistema.Logar(Cassia, "456");
//    sistema.Logar(caio, "888");
//}

//Cliente joaozin = new("Joãozin da Beterraba", "25698654755", "Plantador");

//Console.WriteLine(joaozin.ToString());

#endregion

Cliente ramon = new Cliente("Ramon", "25632658955", "Vendedor de calendario");

    Console.WriteLine(ContaCorrente.TaxaOperacao);



try
{
    ContaCorrente conta1 = new ContaCorrente(ramon, 256, "1865-8");
    conta1.Sacar(50);
    Console.WriteLine();
}
catch(ArgumentException ex)
{
    Console.WriteLine($"Parametro errado {ex.ParamName}");
    Console.WriteLine("Não é possivel criar uma conta com numero de agência menor ou igual a zero.");
    Console.WriteLine(ex.Message);
}








