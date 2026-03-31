static class Player
{
  public static int playerOption;
  public static string? playerOptionStr;

  public static string ExecuteRound()
  {
    while (true)
    {
      Console.WriteLine("\nSua vez de jogar! Escolha uma das opções!");
      Console.WriteLine("1 - Pedra");
      Console.WriteLine("2 - Papel");
      Console.WriteLine("3 - Tesoura");

      Console.Write("\nDigite a sua escolha: ");

      playerOption = Convert.ToInt32(Console.ReadLine());

      switch (playerOption)
      {
        case 1:
          playerOptionStr = "PEDRA";
          break;

        case 2:
          playerOptionStr = "PAPEL";
          break;

        case 3:
          playerOptionStr = "TESOURA";
          break;

        default:
          Console.WriteLine("Opção inválida! Tente novamente");
          Console.Write("Digite ENTER para continuar...");
          Console.ReadLine();
          continue;
      }

      Console.WriteLine($"\nVocê escolheu: {playerOptionStr}!");
      return playerOptionStr;
    }
  }

  public static void CheckWinner(string computerOptionStr)
  {
    if (playerOptionStr == computerOptionStr)
      Console.WriteLine("\nEmpate!");

    else if (
      playerOptionStr == "PEDRA" && computerOptionStr == "TESOURA" ||
      playerOptionStr == "PAPEL" && computerOptionStr == "PEDRA" ||
      playerOptionStr == "TESOURA" && computerOptionStr == "PAPEL"
    )
      Console.WriteLine("\nVocê venceu!");

    else
      Console.WriteLine("\nO computador venceu!");
  }

  public static bool WantsToContinue()
  {
    Console.Write("\nDeseja jogar novamente? [S/N] ");
    string? chosenOption = Console.ReadLine()?.ToUpper();

    if (chosenOption != "S")
      return false;

    return true;
  }
}