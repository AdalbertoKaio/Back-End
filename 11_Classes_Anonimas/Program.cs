public class Program
{
    public static void Main()
    {
        //Criando uma classe anônima (classe sem definição inicial)
        var pessoa1 = new {
            nome = "João",
            idade = 17
        };
        var pessoa2 = new {
            nome = "Maria",
            email = "maria@aluno.senai.br"
        };

        Console.WriteLine($"A pessoa é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"A pessoa é {pessoa2.nome} e tem o email {pessoa2.email}");

        var carro1 = new {
            marca = "BMW",
            modelo = "BMW X3",
            ano = "2003"
        };

        var carro2 = new {
            marca = "ford",
            modelo = "Fiesta",
            ano = "2007"
        };

        Console.WriteLine($"O carro1 tem o é da marca {carro1.marca}, é do modelo {carro1.modelo} e seu ano de fabricação é {carro1.ano}.");
        Console.WriteLine($"O carro2 tem o é da marca {carro2.marca}, é do modelo {carro2.modelo} e seu ano de fabricação é {carro2.ano}.");
        
    }
}