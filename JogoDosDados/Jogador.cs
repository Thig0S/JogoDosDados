using System.Security.Cryptography;

namespace JogoDosDados;

static class Jogador
{
    public static int ExecutarRodada(
        int posicaoJogador,
         int limiteChegada,
         int bonusAvancoExtra,
         int penalidadeRecuo
         )
    {
        do
        {
            Program.ExibirMenu("Jogador");

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
}
