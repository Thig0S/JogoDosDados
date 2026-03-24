namespace JogoDosDados;

class Program
{
    static void Main(string[] args)
    {
        const int limiteChegada = 30;
        const int bonusAvancoExtra = 3;
        const int penalidadeRecuo = 2;

        ExecutarPartida(limiteChegada, bonusAvancoExtra, penalidadeRecuo);
    }
    public static void ExibirMenu(string nome)
    {
        Console.Clear();
        System.Console.WriteLine("---------------");
        System.Console.WriteLine("Jogo dos Dados!");
        System.Console.WriteLine("---------------");
        System.Console.WriteLine($"Rodada do {nome}! ");
        System.Console.WriteLine("---------------");
    }

    static bool DesejaJogarNovamente()
    {
        System.Console.WriteLine("Deseja continuar? (S/N)");
        string? opcaoContinuar = Console.ReadLine()?.ToUpper();

        if (opcaoContinuar != "S")
            return false;

        return true;
    }

    static void ExecutarPartida(int limiteChegada, int bonusAvancoExtra, int penalidadeRecuo)
    {
        while (true)
        {
            int posicaoJogador = 0;
            int posicaoComputador = 0;

            while (true)
            {
                posicaoJogador = Jogador.ExecutarRodada(posicaoJogador,
                limiteChegada,
                bonusAvancoExtra,
                penalidadeRecuo
                );

                if (posicaoJogador >= limiteChegada)
                    break;

                posicaoComputador = Computador.ExecutarRodada(
                posicaoComputador,
                limiteChegada,
                bonusAvancoExtra,
                penalidadeRecuo);

                if (posicaoComputador >= limiteChegada)
                    break;

            }
            if (!DesejaJogarNovamente())
            {
                break;
            }
        }
    }
}
