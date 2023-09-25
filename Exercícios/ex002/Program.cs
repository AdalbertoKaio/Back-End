Console.WriteLine("Digite sua placa");
String placa = Console.ReadLine();

String ultimo = placa.Substring(placa.Length-1, 1);

Console.WriteLine($"0 seu final é {ultimo}");

if (ultimo == "1" || ultimo == "2"){
    Console.WriteLine("Você não pode andar na segunda-feira");
} else if(ultimo == "3" || ultimo == "4"){
    Console.WriteLine("Você não pode andar na terça-feira");
}
else if( ultimo == "5" || ultimo == "6"){
    Console.WriteLine("Você não pode andar na quarta-feira");
}
else if( ultimo == "7" || ultimo == "8"){
    Console.WriteLine("Você não pode andar na quinta-feira");
}
else if( ultimo == "9" || ultimo == "0"){
    Console.WriteLine("Você não pode andar na sexta-feira");
}