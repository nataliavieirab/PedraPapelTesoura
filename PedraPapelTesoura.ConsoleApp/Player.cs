static class Player
{
  public static int playerOption;
  public static string? playerOptionStr;


  public static string ChooseOption()
  {
    while (true)
    {
      GetPlayerMenu();

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

  static void GetPlayerMenu()
  {
    Console.WriteLine("\nSua vez de jogar!");
    Console.WriteLine("\n>> Escolha uma das opções:");
    Console.WriteLine("1 - Pedra");
    Console.WriteLine("2 - Papel");
    Console.WriteLine("3 - Tesoura");
  }
}