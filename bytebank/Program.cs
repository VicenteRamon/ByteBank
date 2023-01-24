using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "Andre Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 100;

Console.WriteLine($"Saldo da conta do Andre = R${contaDoAndre.saldo}");


contaDoAndre.Depositar(100);

Console.WriteLine($"Saldo da conta do Andre pós-deposito = R${contaDoAndre.saldo}");

if (contaDoAndre.Sacar(300) == true)
{
    Console.WriteLine($"Saldo da conta do Andre pós-saque = R${contaDoAndre.saldo}");
}
else
{
    Console.WriteLine("Tem grana não meu fi!!");
}


