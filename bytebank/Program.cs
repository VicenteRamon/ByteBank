using bytebank.Contas;
using bytebank.Funcionarios;
using bytebank.Parceria;
using bytebank.SistemaInterno;
using bytebank.Titular;
using bytebank.Utilitario;
using System.Collections.Concurrent;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.CompilerServices;

Console.WriteLine("Bem vindo ao Byte bank");

#region
//TestaArray();
//TestaBuscarPalavra();


void TestaArray()
{
    int idade = 30;

    int[] idades = new int[5];

    idades[0] = 5;
    idades[1] = 65;
    idades[2] = 3;
    idades[3] = 7;
    idades[4] = 8;

    Console.WriteLine($"Tamanho do Array {idades.Length}"); 

    for(int i = 0; i < idades.Length; i++)
    {
        Console.WriteLine($"Indice[{i}] idades {idades[i]}");
    };

}


void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];
    
    for(int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i+1}ª palavra: ");
        arrayDePalavras[i] = Console.ReadLine();

    }

    Console.WriteLine("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (var palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine("ACHOU!");
            Console.WriteLine($"Encontramos a palavra{palavra} que esta na posição {palavra}");
        }
    }
}

void CriaAmostra()
{
    Array amostra = Array.CreateInstance(typeof(double), 5);

    amostra.SetValue(5.9, 0);
    amostra.SetValue(1.8, 1);
    amostra.SetValue(7.1, 2);
    amostra.SetValue(10, 3);
    amostra.SetValue(6.9, 4);

}

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array vazio");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = numerosOrdenados.Length / 2;

    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"mediana igual {mediana}");
}


//TestaMediana(amostra);



//Array Vl = Array.CreateInstance(typeof(double), 9);

//for (int i = 0; i < Vl.Length; i++)
//{
//    Console.WriteLine($"Insira o {i + 1}ª valor: ");
//    double input = Convert.ToDouble(Console.ReadLine());
//    Vl.SetValue(input, i);
//}


void CaMedia(Array array)
{
    var total = 0.0;

    if (array.Length == 0 || array == null)
    {
        Console.WriteLine("Sem valor");
        return;
    }

    foreach (var value in array)
    {
        Console.WriteLine(value);
        total = total + (double)value;
    }

    double metade = total / array.Length;

    Console.WriteLine($"A media do array é {metade}");
}


void TestaArrayDeContas()
{

    Cliente[] ListaDeClientes = new Cliente[]
    {
        new Cliente("Ramon","12125452154","Estudante"),
        new Cliente("Cássia","89658745896","Estudante"),
        new Cliente("Vicente","11125444785","Estudante")

    };

    ContaCorrente[] ListaDeContas = new ContaCorrente[]
    {
        new ContaCorrente(ListaDeClientes[0],2515,"52155-8"),
        new ContaCorrente(ListaDeClientes[1],5869,"58693-9"),
        new ContaCorrente(ListaDeClientes[2],2511,"11111-1")
    };

    for (int i = 0; i < ListaDeContas.Length; i++)
    {
        Console.WriteLine($"Indice: {i} Conta Corrente {ListaDeContas[i].Conta}");
    }

    Console.WriteLine(ContaCorrente.TaxaOperacao);
}

//TestaArrayDeContas();

//Cliente Ramon = new Cliente("Ramon","56985698569","Estudante");
//Cliente Cassia = new Cliente("Cássia", "56985698569", "Estudante");
//Cliente Vicente = new Cliente("Vicente", "56985698569", "Estudante");

//ContaCorrente vicente = new ContaCorrente(Vicente, 25632, "5263-8");

//ListaDeContasCorrentes lista = new ListaDeContasCorrentes();
//lista.Adicionar(new ContaCorrente(Ramon, 5658, "526562-5"));
//lista.Adicionar(new ContaCorrente(Cassia, 5658, "526562-5"));
//lista.Adicionar(vicente);

//lista.mostrar();

//Console.WriteLine("===========");

//lista.Remover(vicente);

//lista.mostrar();

//for (int i = 0; i < lista.Tamanho; i++)
//{
//    ContaCorrente conta = lista[i];
//    Console.WriteLine($"Indice [{i}] = Conta  {conta.Conta}/{conta.Numero_agencia}");
//}
#endregion

