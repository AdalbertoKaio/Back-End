namespace models
{
    public class Pessoa
    {
        //Atributos da nossa clase pessoas 
        public string nome { get; set; }
        public int idade { get; set; }
        public string email { get; set; }
        public int anoNascimento { get; set; }

        public Pessoa (string nomePessoa, int idadePessoa, string emailPessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = DateTime.Now.Year - idadePessoa;
        }

        //Método da classe pessoas
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

        public void Informacoes()
        {
            Console.WriteLine($"{nome} tem {idade} anos. Seu email é {email} e nasceu no ano de {anoNascimento}.");
        }
    }
}