using System.Diagnostics;

namespace JogarDados;

class Program
{
    public static int pontosJogadorUm = 0;
    public static int pontosJogadorDois = 0;
    public static string jogadorUm;
    public static string jogadorDois;

    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {

        Console.Clear();
        Console.WriteLine("Digite o nome do primeiro jogador: ");
        jogadorUm = Console.ReadLine();

        do
        {
            Console.WriteLine("Digite o segundo jogador: ");
            jogadorDois = Console.ReadLine();

            if (jogadorUm == jogadorDois)
            {
                Console.WriteLine("Os nomes não podem ser iguais! Tente novamente.");
            }
        } while (jogadorUm == jogadorDois);

        Console.WriteLine($"Jogador um: {jogadorUm}\nJogador dois: {jogadorDois}");
        Console.WriteLine("======================");
        Thread.Sleep(1000);
        Console.WriteLine("Inciando jogo!");
        Thread.Sleep(3000);

        int rodada = 1;
        for (var i = 0; i < 3; i++)
        {
            RodaDados(rodada);
            Thread.Sleep(4000);
            rodada++;
        }

        if (pontosJogadorUm > pontosJogadorDois)
        {
            Console.WriteLine($"Jogador {jogadorUm} ganhou!");
        }
        else if (pontosJogadorUm < pontosJogadorDois)
        {
            Console.WriteLine($"Jogador {jogadorDois} ganhou!");
        }
        else
        {
            Console.WriteLine("Empate!");
        }

        Console.WriteLine($"Resultados: {jogadorUm} = {pontosJogadorUm} pontos!\n{jogadorDois} = {pontosJogadorDois} pontos!");

    }

    static void RodaDados(int rodada)
    {
        Console.Clear();
        Console.WriteLine($"{rodada}ª rodada!");
        Thread.Sleep(1000);
        int resultadoJogadorUm = JogarDados();
        int resultadoJogadorDois = JogarDados();

        if (resultadoJogadorUm > resultadoJogadorDois)
        {
            Console.WriteLine($"Jogador {jogadorUm} ganhou!");
            pontosJogadorUm++;
        }
        else if (resultadoJogadorUm < resultadoJogadorDois)
        {
            Console.WriteLine($"Jogador {jogadorDois} ganhou!");
            pontosJogadorDois++;
        }
        else
        {
            Console.WriteLine("Empate!");
        }

        Console.WriteLine($"Resultados: {jogadorUm} = {resultadoJogadorUm}\n{jogadorDois} = {resultadoJogadorDois}\n");
        Console.WriteLine($"Resultados: {jogadorUm} = {pontosJogadorUm} pontos!\n{jogadorDois} = {pontosJogadorDois} pontos!\n");
    }


    static int JogarDados()
    {
        Random random = new Random();
        int dado = random.Next(1, 7);
        return dado;
    }
}