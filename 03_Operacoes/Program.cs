﻿Console.WriteLine("Digite o valor de x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine())

//Exemplos de operações aritméticos 
int soma = x + y; 
int subtração = x - y;
int multiplicação = x * y;
int divisão = x / y;
int resto = x % y;
int restoDvi2 = x % 2; //Calculando o resto de divisão de x / 2
int restoDiv3 = y % 2; 

//Console para exibir na tela as variáveis em cada linha 
//Soma: 15 
Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração:" + subtração);
Console.WriteLine($"Multiplicação:" + multiplicação);
Console.WriteLine($"Divisão:" + divisão);
Console.WriteLine($"Resto:" + resto);

if (restoDvi2 == 0)
{
    Console.WriteLine($"O número {x} é par");
}
else{
    Console.WriteLine($"O número {x} é impar");
}

if (restoDiv3 == 0)
{
    Console.WriteLine($"O número {y} é par");
}
else{
    Console.WriteLine($"O número {y} é impar");
}

//Operador ternário 
// condição ? se verdade : senão 
String resultado = (restoDiv3 == 0) ? $"O número {y} é par" : $"O número {y} é par";
Console.WriteLine(resultado); 

int diaSemana = 3;
//Aprendendo o Switch Case
Switch (diaSemana)
{
    case 1:
    Console.WriteLine("Hoje é domingo")
    break;

    case 2:
    Console.WriteLine("Hoje é segunda")
    break;

    case 3:
    Console.WriteLine("Hoje é terça")
    break;

    case 3:
    Console.WriteLine("Hoje é quarta")
    break;
    
    case 3:
    Console.WriteLine("Hoje é quinta")
    break;

    case 3:
    Console.WriteLine("Hoje é sexta")
    break;

    case 3:
    Console.WriteLine("Hoje é sábado")
    break;

    default:
    Console.WriteLine("Hoje é inválido")
    break;
}


