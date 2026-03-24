namespace JogoDosDados;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            IniciarPartida();

            while (true)
            {
                Jogador.ExecutarRodada();

                if (Jogador.Venceu())
                    break;

                Computador.ExecutarRodada();

                if (Computador.Venceu())
                    break;
            }
            if (!DesejaJogarNovamente())
            {
                break;
            }
        }
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
    static void IniciarPartida()
    {
        Jogador.posicaoJogador = 0;
        Computador.posicaoComputador = 0;
    }
}
