using System.Security.Cryptography;

namespace JogoDosDados;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            System.Console.WriteLine("---------------");
            System.Console.WriteLine("Jogo dos Dados!");
            System.Console.WriteLine("---------------");

            System.Console.Write("Digite ENTER para lancar um dado: ");
            Console.ReadLine();
            int resultado = RandomNumberGenerator.GetInt32(1,7);

            System.Console.WriteLine("---------------");
            System.Console.WriteLine($"O numero sorteado foi: {resultado}");
            System.Console.WriteLine("---------------");

            System.Console.WriteLine("Deseja continuar? (S/N)");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if(opcaoContinuar != "S")
                break;

            
        }
    }
}
