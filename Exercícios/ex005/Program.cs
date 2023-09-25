class ex005
{

public static void Main()
{
    ListaDoChurrasco();
    //SonhoDeConsumo = ();
}

public static void ListaDoChurrasco()
{
    string[] lista = new string[6];
    for (int i = 0; i < 6; i++)
    {
    Console.WriteLine("Digite o produto que vamos comprar");
    string produto = Console.ReadLine();
    lista[i] = produto;
    }

    Array.Sort(lista);

    foreach (string item in lista){
        Console.WriteLine(item);
    }
} 
public static void SonhoDeConsumo()
{
    string[] sonhos = new string[3];
    decimal[] valores = new decimal[3];
    deciaml total = 0;

    for (int i = 0; i < 3 i++ )
    {
        Console.WriteLine("Digite seus {i}° sonho");
        string sonho = Console.ReadLine();
        Console.WriteLine($"Informe o valor do {i}° sonho");
        deciaml valor = decimal.Parse(Console.ReadLine());
        sonhos[i] = sonho;
        valores[i] = valor;
    }

    foreach (decimal val in valores)
    {
        total = total + val;
    }
    Console.WriteLine($"Seus sonhos custarão aprox. R${total}");
}
}