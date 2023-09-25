Console.WriteLine("Digite o nome do aluno:");
string nome = Console.ReadLine();
Console.WriteLine("Digite a nota 1:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 2:");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 3");
int z = int.Parse(Console.ReadLine());

int média = (x + y + z) / 3;

Console.WriteLine($"Média:"+ média);

string resultado = (média >=7) ? $"A média do aluno foi {média} Aprovado!" : $"A média do aluno foi {média}, repetiu de ano";
Console.WriteLine(resultado);
