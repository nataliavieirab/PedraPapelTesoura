static class Jogador
{

  public static int opcaoJogador;
  public static string strOpcaoJogador;

  public static string ExecutarRodada()
  {
    while (true)
    {

      Console.WriteLine("\nSua vez de jogar! Escolha uma das opções!");
      Console.WriteLine("1 - Pedra");
      Console.WriteLine("2 - Papel");
      Console.WriteLine("3 - Tesoura");

      Console.Write("\nDigite a sua escolha: ");

      opcaoJogador = Convert.ToInt32(Console.ReadLine());


      switch (opcaoJogador)
      {
        case 1:
          strOpcaoJogador = "PEDRA";
          break;

        case 2:
          strOpcaoJogador = "PAPEL";
          break;

        case 3:
          strOpcaoJogador = "TESOURA";
          break;

        default:
          Console.WriteLine("Opção inválida! Tente novamente");
          Console.Write("Digite ENTER para continuar...");
          Console.ReadLine();
          continue;
      }

      Console.WriteLine($"\nVocê escolheu: {strOpcaoJogador}!");
      return strOpcaoJogador;
    }
  }

  public static void Ganhou(string strOpcaoComputador)
  {

    if (strOpcaoJogador == strOpcaoComputador)
      Console.WriteLine("\nEmpate!");

    else if (strOpcaoJogador == "PEDRA" && strOpcaoComputador == "TESOURA" || strOpcaoJogador == "PAPEL" && strOpcaoComputador == "PEDRA" || strOpcaoJogador == "TESOURA" && strOpcaoComputador == "PAPEL")
      Console.WriteLine("\nVocê venceu!");

    else
      Console.WriteLine("\nO computador venceu!");
  }

  public static bool DesejaContinuar()
  {
    Console.Write("\nDeseja jogar novamente? [S/N] ");
    string? opcaoEscolhida = Console.ReadLine()?.ToUpper();

    if (opcaoEscolhida != "S")
      return false;

    return true;
  }
}