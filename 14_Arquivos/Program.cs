using System.IO;

public class Program
{
    public static void CaminhoArquivo = "Arquivo/arquivo2.txt";
    public static void Main()
    {
        GravarArquivo();
        LerArquivo();
    }

    public static void LerArquivo()
    {
        string CaminhoArquivo = CaminhoArquivo
        try
        {
            using (StreamReader arquivo = new StreamReader(CaminhoArquivo))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {erro.Message}");
        }
    }
    public static void GravarArquivo()
    {
        try
        {
            if (File.Exists("Arquivo/arquivo.txt") == false)
            {
                //Criando meu arquivo.txt, este comando é executado quando a verificação no if é falsa ou seja o arquivo não existe
                File.Create("Arquivo/arquivo.txt");
            }
            using (StreamWriter arquivo = new StreamWriter("Arquivo/arquivo.txt", true))
            {
                Console.WriteLine("Digite uma informação para poder gerar no arquivo");
                arquivo.WriteLine(Console.ReadLine());
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }
}
