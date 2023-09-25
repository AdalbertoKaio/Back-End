public class Program
{
    public static void Main()
    {
        //o try serve para tratar um erro e não parar a execução do programa
        //Se ocorrer qualquer erro dentro do bloco try, o sistema interrompe
        //a execução do bloco e vai para o cacth
        try{
        
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o nº {numero}");
            int resultado = 10 / numero;
            Console.WriteLine($"O resultado é: {resultado}");

        } 
        catch(OverflowException)
        {
            Console.WriteLine("Este número inteiro é maior que o suportado");
        }
        //Tratanto exceção de erro de formato
        catch(FormatException)
        {
            Console.WriteLine("Erro: Digite um número inteiro");
        }
        //cacth é o tratamento do erro, normalmente colocamos mensagens de acordo com o tipo do erro, para melhor compreensão do usuário
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message} ");
        }
        finally
        {
            Console.WriteLine("Entrando no finally");
        }
    }
}