using models;

public class Program
{
    public static void Main()
    {
        //Criando um objeto da classe Pessoa
        //Instanciando sem um método construtor
        /*Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Kaio";
        pessoa1.idade = 16;
        pessoa1.email = "adalberto.albuquerque@aluno.senai.br";
        pessoa1.Cantar();

        //Alternativa para criação de um objeto sem construtor
        Pessoa pessoa2 = new Pessoa{
            nome = "Bruna",
            idade = 16,
            email = "bruna.dutra@aluno.senai.br"
        };
        pessoa2.Cantar();
        */
        
        Pessoa pessoa1 = new Pessoa("Kaio", 16, "adalberto.albuquerque@aluno.senai.br");
        pessoa1.Cantar();
        pessoa1.Informacoes();

        Pessoa pessoa2 = new Pessoa("Bruna" , 16 , "bruna.dutra@aluno.senai.br");
        pessoa2.Cantar();
        pessoa2.Informacoes();
        
    }
}