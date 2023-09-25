using models;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo ao seu Sistema Bancário");
        Console.WriteLine("*********************************");
        Console.WriteLine("Aqui está seu menu de acesso");

        Menu();
    }

    public static void Menu()
    {
        Console.WriteLine($"Digite seu nome");

        string Titular = Console.ReadLine();

        contaCorrente contaCorrente1 = new contaCorrente(Titular);

        string opcao = "";

        do
        {
            Console.WriteLine("######## MENU ########");
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Sair");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "4":
                    Console.WriteLine("Obrigado, volte sempre!!!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "1":
                    contaCorrente1.consultarSaldo();
                    break;
                case "2":
                    Console.WriteLine($"Digite o valor para depósito:");
                    int Valor = int.Parse(Console.ReadLine());
                    contaCorrente1.Depositar(Valor);
                    break;
                case "3":
                    Console.WriteLine($"Digite o valor que deseja sacar:");
                    int SacarValor = int.Parse(Console.ReadLine());
                    contaCorrente1.Sacar(SacarValor);
                    break;
                default:
                    break;
            }
        } while (opcao != "4");
    }
}