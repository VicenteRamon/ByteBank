using bytebank.Contas;
using bytebank.Titular;


ContaCorrente conta = new ContaCorrente();
conta.Titular = new Cliente();
conta.Titular.Nome = "Jose das quantas";
conta.Conta = "1010-x";
conta.Numero_agencia = 15;
conta.SetSaldo(-50);

ContaCorrente contaMaria = new ContaCorrente();
contaMaria.Titular = new Cliente();
contaMaria.SetSaldo(50);


Console.WriteLine(conta.GetSaldo());


