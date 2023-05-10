using bytebank.Contas;
using bytebank.Funcionarios;
using bytebank.Parceria;
using bytebank.SistemaInterno;
using bytebank.Titular;
using bytebank.Utilitario;
using System.Collections.Concurrent;
using System.Net.Http.Headers;
using System.Numerics;


Console.WriteLine("Bem vindo ao Byte bank");

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


Array amostra = Array.CreateInstance(typeof(double), 5);

amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

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



Array Vl = Array.CreateInstance(typeof(double), 9);

for (int i = 0; i < Vl.Length; i++)
{
    Console.WriteLine($"Insira o {i + 1}ª valor: ");
    double input = Convert.ToDouble(Console.ReadLine());
    Vl.SetValue(input, i);
}


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

CaMedia(Vl);