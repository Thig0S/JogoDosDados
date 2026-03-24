using System.Security.Cryptography;

namespace JogoDosDados;

static class Jogador
{

}

class Program
{
    static void ExibirMenu(string nome)
    {
        Console.Clear();
        System.Console.WriteLine("---------------");
        System.Console.WriteLine("Jogo dos Dados!");
        System.Console.WriteLine("---------------");
        System.Console.WriteLine($"Rodada do {nome}! ");
        System.Console.WriteLine("---------------");
    }
    static int ExecutarRodadaJogador(
    int posicaoJogador,
     int limiteChegada,
     int bonusAvancoExtra,
     int penalidadeRecuo
     )
    {
        do
        {
            ExibirMenu("Jogador");

            System.Console.Write("Digite ENTER para lancar um dado: ");
            Console.ReadLine();
            int resultadoJogador = RandomNumberGenerator.GetInt32(1, 7);

            System.Console.WriteLine("---------------");
            System.Console.WriteLine($"O numero sorteado foi: {resultadoJogador}");
            System.Console.WriteLine("---------------");

            posicaoJogador += resultadoJogador;
            System.Console.WriteLine($"Voce esta na posicao: {posicaoJogador} de {limiteChegada}");
            if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15 || posicaoJogador == 20 || posicaoJogador == 25)
            {
                System.Console.WriteLine($"Evento: AVANCO DE {bonusAvancoExtra} casas");
                posicaoJogador += bonusAvancoExtra;
                System.Console.WriteLine($"Voce esta na posicao: {posicaoJogador} de {limiteChegada}");
            }
            else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
            {
                System.Console.WriteLine($"EVENTO: RECUO DE {penalidadeRecuo} casas");
                posicaoJogador -= penalidadeRecuo;
                System.Console.WriteLine($"Voce esta na posicao: {posicaoJogador} de {limiteChegada}");
            }
            if (posicaoJogador >= limiteChegada)
            {
                System.Console.WriteLine("\nParabens voce chegou na linha de chegada! ");
                System.Console.WriteLine();

                break;
            }
            if (resultadoJogador == 6)
            {
                System.Console.WriteLine("EVENTO 6: Rodada Extra para o jogador!");
                System.Console.WriteLine("---------------------------");
                System.Console.WriteLine("Digite ENTER para jogar novamente...");
                Console.ReadLine();

                continue;
            }
            else
            {
                System.Console.WriteLine("Digite ENTER para continuar...");
                Console.ReadLine();
                break;
            }
        } while (true);
        return posicaoJogador;
    }

    static int ExecutarRodadaComputador(int posicaoComputador,
    int limiteChegada,
    int bonusAvancoExtra,
    int penalidadeRecuo)
    {
        do
        {
            ExibirMenu("Computador");

            int resultadoComputador = RandomNumberGenerator.GetInt32(1, 7);

            System.Console.WriteLine("---------------");
            System.Console.WriteLine($"O numero sorteado foi: {resultadoComputador}");
            System.Console.WriteLine("---------------");

            posicaoComputador += resultadoComputador;

            System.Console.WriteLine($"O computador esta na: {posicaoComputador} de {limiteChegada}");

            System.Console.WriteLine($"O computador esta na posicao: {posicaoComputador} de {limiteChegada}");
            if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 20 || posicaoComputador == 25)
            {
                System.Console.WriteLine($"Evento: AVANCO DE {bonusAvancoExtra} casas");
                posicaoComputador += bonusAvancoExtra;
                System.Console.WriteLine($"O computador esta na posicao: {posicaoComputador} de {limiteChegada}");
            }
            else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
            {
                System.Console.WriteLine($"EVENTO: RECUO DE {penalidadeRecuo} casas");
                posicaoComputador -= penalidadeRecuo;
                System.Console.WriteLine($"O computador esta na posicao: {posicaoComputador} de {limiteChegada}");
            }
            if (posicaoComputador >= limiteChegada)
            {
                System.Console.WriteLine("\nO computador chegou na linha de chegada! ");
                System.Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
                break;
            }
            if (resultadoComputador == 6)
            {
                System.Console.WriteLine("EVENTO 6: Rodada Extra para o Computador!");
                System.Console.WriteLine("---------------------------");
                System.Console.WriteLine("Digite ENTER para jogar novamente...");
                Console.ReadLine();

                continue;
            }
            else
            {
                System.Console.WriteLine("Digite ENTER para continuar...");
                Console.ReadLine();
                break;
            }
        } while (true);
        return posicaoComputador;
    }
    static void Main(string[] args)
    {
        const int limiteChegada = 30;
        const int bonusAvancoExtra = 3;
        const int penalidadeRecuo = 2;

        while (true)
        {
            int posicaoJogador = 0;
            int posicaoComputador = 0;

            while (true)
            {
                posicaoJogador = ExecutarRodadaJogador(posicaoJogador,
                limiteChegada,
                bonusAvancoExtra,
                penalidadeRecuo
                );

                if (posicaoJogador >= limiteChegada)
                    break;

                posicaoComputador = ExecutarRodadaComputador(
                posicaoComputador,
                limiteChegada,
                bonusAvancoExtra,
                penalidadeRecuo);

                if (posicaoComputador >= limiteChegada)
                    break;

            }
            System.Console.WriteLine("Deseja continuar? (S/N)");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }
}
