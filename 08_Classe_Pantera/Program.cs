using Animais.Model;


class Program 
{
    public static void Main()
    {

        //Criando uma variável aluno1 e instanciando da classe Aluno ou seja, estamos criando nosso objeto
        var pantera1 = new Pantera();
        //Atribuindo um valor ao atributo nome do Aluno1 
        pantera1.tamanho = 1.60;
        pantera1.peso = 50;
        pantera1.cor = "preta";
        pantera1.especie = "pantera onca";
        pantera1.alimentacao = "pequenos herbívoros, lebres, répteis, insetos, enguias, peixes e ocasionalmente carniça";
        //Chamando o método da classe Aluno
        pantera1.Correr();
        pantera1.Cacar();
        pantera1.Reproduzir();
    }
}