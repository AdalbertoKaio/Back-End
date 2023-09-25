namespace models
{
    public class contaCorrente
    {
        private string Titular { get; set; }

        private int Saldo { get; set; } = 0;


        //construtor
          public contaCorrente (string titularPessoa)
        {
            this.Titular = titularPessoa;
            
        }
        public void consultarSaldo()
        {
            Console.WriteLine($"Seu saldo é {Saldo}.");
        }
        public void Depositar(int valorDeposito)
        {
            Saldo += valorDeposito;
            Console.WriteLine($"Valor depositado com sucesso!");
        }
        public void Sacar(int valorSaque)
        {
            if (valorSaque > Saldo)
            {
                Console.WriteLine($"O valor que você deseja sacar é insuficiente");
            }
            else
            {
                Console.WriteLine($"Você sacou {valorSaque} da sua conta!");
                Saldo -= valorSaque;
            }
        }
    }


}
