class program{
    public static void Main()
    {
       int Multiplicacao = Multiplicacao(int.Parse(Console.ReadLine()));
       Console.WriteLine($"O dobro é {Multiplicacao}");

       int Divisao = Divisao(int.Parse(Console.ReadLine()));
       double result = Multiplicacao(multiplicacao);
       Console.WriteLine($" A metade é {Divisao}");

       Tabuada(int.Parse(Console.ReadLine()));

       ResumoSalarios();
    } 
    
    public static int Multiplicacao(int num)
    {
        int resultado = (num*2);
        return resultado;
    }

    public static int Divisao(int num)
    {
        int resultado = num/2;
        return resultado;
    }

    public static void Tabuada(int numero)
    {
        int contador = 1;
        while(contador <=10){
            Console.WriteLine($"{contador} x {numero} - {contador * numero}");
            contador++;
        }
    }

    public static void ResumoSalarios()
    {
        int somaSalarios = 0;
        int menorSalario = 100000;
        int maiorSalario = 0;
        int salarioEmpregado = 0;

        do {
            Console.WriteLine("Digite o salário do empregado:");
            int salarioEmpregado = int.Parse(Console.ReadLine());

            somaSalarios = somaSalarios + salarioEmpregado;
            if (salarioEmpregado > maiorSalario){
                maiorSalario = salarioEmpregado;
            }
            if(salarioEmpregado < menorSalario)
            menorSalario = salarioEmpregado;

        } while (salarioEmpregado > 0)
        Console.WriteLine($"A soma dos salários é {somaSalarios} o maior salário é {maiorSalario} e o menor salário é {menorSalario}");
    }
}