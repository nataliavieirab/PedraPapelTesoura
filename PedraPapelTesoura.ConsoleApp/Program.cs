namespace PedraPapelTesoura.ConsoleApp;

class Program
{
  static void Main(string[] args)
  {
    Start();
  }

  static void Start()
  {
    while (true)
    {
      ShowHeader();

      Console.WriteLine("\n------------Rodada do Jogador------------");
      Player.ExecuteRound();

      Console.WriteLine("\n----------Rodada do Computador-----------");
      string computerChoiceStr = Computer.ExecuteRound();

      Console.WriteLine("\nDigite ENTER para ver o resultado...");
      Console.ReadLine();

      Console.WriteLine("----------Resultado da Rodada-----------");
      Player.CheckWinner(computerChoiceStr);

      if (!Player.WantsToContinue())
        break;
    }
  }

  static void ShowHeader()
  {
    Console.Clear();
    Console.WriteLine("=========================================");
    Console.WriteLine("----------Pedra, Papel e Tesoura---------");
    Console.WriteLine("=========================================");
  }
}