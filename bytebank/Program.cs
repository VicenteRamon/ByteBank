using bytebank.Contas;
using bytebank.Titular;
using System.Collections.Concurrent;


//ContaCorrente conta = new ContaCorrente();
//conta.Titular = new Cliente();
//conta.Titular.Nome = "Jose das quantas";
//conta.Conta = "1010-x";
//conta.Numero_agencia = 15;
//conta.SetSaldo(-50);

//ContaCorrente contaMaria = new ContaCorrente();
//contaMaria.Titular = new Cliente();
//contaMaria.SetSaldo(50);


//Console.WriteLine(conta.GetSaldo());

//ContaCorrente conta4 = new ContaCorrente(18, "1010-x");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();


//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

Cliente Ramon = new Cliente("Ramon", "12512512502", "atoa");
ContaCorrente conta5 = new ContaCorrente(Ramon, 283, "1234-x");
Console.WriteLine(conta5.Titular.Nome + conta5.Conta);





