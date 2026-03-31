using System.Security.Cryptography;

static class Computer
{
  public static int computerOption;
  public static string? computerOptionStr;

  public static string ChooseOption()
  {
    computerOption = RandomNumberGenerator.GetInt32(1, 4);

    if (computerOption == 1) computerOptionStr = "PEDRA";
    else if (computerOption == 2) computerOptionStr = "PAPEL";
    else computerOptionStr = "TESOURA";

    Console.WriteLine($"\nO computador escolheu a opção: {computerOptionStr}");
    return computerOptionStr;
  }
}