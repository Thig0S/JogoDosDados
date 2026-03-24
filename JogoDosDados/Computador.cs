using System.Security.Cryptography;

namespace JogoDosDados;

static class Computador
{
    public static int ExecutarRodada(int posicaoComputador,
    int limiteChegada,
    int bonusAvancoExtra,
    int penalidadeRecuo)
    {
        do
        {
            Program.ExibirMenu("Computador");

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
}
