namespace Animais.Model
{

    public class Pantera
    {

        public double tamanho { get; set; }

        public int peso {get; set; }

        public string cor { get; set; }

        public string especie {get; set; }

        public string alimentacao {get; set; }

        public void Correr()
        {
            Console.WriteLine($"Eu sou {especie} e estou correndo");
        }

        public void Cacar()
        {
         Console.WriteLine($"Eu sou {especie} e estou caçando");
        }

        public void Reproduzir()
        {
            Console.WriteLine($"Eu sou {especie} e estou reproduzindo");
        }
    }
}