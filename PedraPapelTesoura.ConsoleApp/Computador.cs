using System.Security.Cryptography;

static class Computador
{

  public static int opcaoComputador;
  public static string strOpcaoComputador;
  public static string ExecutarRodada()
  {

    opcaoComputador = RandomNumberGenerator.GetInt32(1, 4);

    if (opcaoComputador == 1) strOpcaoComputador = "PEDRA";
    else if (opcaoComputador == 2) strOpcaoComputador = "PAPEL";
    else strOpcaoComputador = "TESOURA";

    Console.WriteLine($"\nO computador escolheu a opção: {strOpcaoComputador}");
    return strOpcaoComputador;
  }
}