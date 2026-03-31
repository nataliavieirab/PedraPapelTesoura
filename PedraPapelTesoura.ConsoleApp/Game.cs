static class Game
{

  public static void Start()
  {
    while (true)
    {
      ShowHeader();

      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("\n----------- Rodada do Jogador -------------");

      Console.ForegroundColor = ConsoleColor.White;

      string playerOptionStr = Player.ChooseOption();

      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("\n---------- Rodada do Computador -----------");

      Console.ForegroundColor = ConsoleColor.White;

      string computerOptionStr = Computer.ChooseOption();

      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("\nDigite ENTER para ver o resultado...");
      Console.ReadLine();

      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine("========== RESULTADO DA RODADA ============");

      Console.ForegroundColor = ConsoleColor.Yellow;
      // Console.WriteLine($"\n------------ {playerOptionStr} vs {computerOptionStr} -------------");
      Console.WriteLine($"\n            {playerOptionStr} vs {computerOptionStr}");

      Console.ForegroundColor = ConsoleColor.White;

      CheckWinner(playerOptionStr, computerOptionStr);

      if (!WantsToContinue())
        break;
    }
  }
  static void CheckWinner(string playerOptionStr, string computerOptionStr)
  {
    if (playerOptionStr == computerOptionStr)
      Console.WriteLine("\n>> Empate!");

    else if (
      playerOptionStr == "PEDRA" && computerOptionStr == "TESOURA" ||
      playerOptionStr == "PAPEL" && computerOptionStr == "PEDRA" ||
      playerOptionStr == "TESOURA" && computerOptionStr == "PAPEL"
    )
      Console.WriteLine("\n>> Parabéns! Você venceu :)");

    else
      Console.WriteLine("\n>> O computador venceu!");
  }
  static bool WantsToContinue()
  {
    Console.Write("\nDeseja jogar novamente? [S/N] ");
    string? chosenOption = Console.ReadLine()?.ToUpper();

    if (chosenOption != "S")
      return false;

    return true;
  }

  static void ShowHeader()
  {
    Console.ForegroundColor = ConsoleColor.DarkMagenta;

    Console.Clear();
    Console.WriteLine("===========================================");
    Console.WriteLine("--------- Pedra, Papel e Tesoura ----------");
    Console.WriteLine("===========================================");

    Console.ForegroundColor = ConsoleColor.White;
  }
}