using System.Security.Cryptography;

namespace PedraPapelTesoura.ConsoleApp;

class Program
{
  static void Main(string[] args)
  {

    while (true)
    {
      ExibirCabecalho();

      string strOpcaoJogador = ExecutarRodadaJogador();

      string strOpcaoComputador = ExecutarRodadaComputador();

      Console.WriteLine("\nDigite ENTER para ver o resultado...");
      Console.ReadLine();

      ExecutarLogicaVencedor(strOpcaoJogador, strOpcaoComputador);

      if (!DesejaContinuar())
        break;
    }

    Console.ReadLine();

  }

  static void ExibirCabecalho()
  {
    Console.Clear();
    Console.WriteLine("=========================================");
    Console.WriteLine("----------Pedra, Papel e Tesoura---------");
    Console.WriteLine("=========================================");
  }

  static string ExecutarRodadaJogador()
  {
    while (true)
    {
      Console.WriteLine("\n------------Rodada do Jogador------------");

      Console.WriteLine("\nSua vez de jogar! Escolha uma das opções!");
      Console.WriteLine("1 - Pedra");
      Console.WriteLine("2 - Papel");
      Console.WriteLine("3 - Tesoura");

      Console.Write("\nDigite a sua escolha: ");

      int opcaoJogador = Convert.ToInt32(Console.ReadLine());

      string strOpcaoJogador;

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

  static string ExecutarRodadaComputador()
  {
    Console.WriteLine("\n----------Rodada do Computador-----------");

    int opcaoComputador = RandomNumberGenerator.GetInt32(1, 4);

    string strOpcaoComputador;

    if (opcaoComputador == 1) strOpcaoComputador = "PEDRA";
    else if (opcaoComputador == 2) strOpcaoComputador = "PAPEL";
    else strOpcaoComputador = "TESOURA";

    Console.WriteLine($"\nO computador escolheu a opção: {strOpcaoComputador}");
    return strOpcaoComputador;
  }

  static void ExecutarLogicaVencedor(string strOpcaoJogador, string strOpcaoComputador)
  {
    Console.WriteLine("----------Resultado da Rodada-----------");

    if (strOpcaoJogador == strOpcaoComputador)
      Console.WriteLine("\nEmpate!");

    else if (strOpcaoJogador == "PEDRA" && strOpcaoComputador == "TESOURA" || strOpcaoJogador == "PAPEL" && strOpcaoComputador == "PEDRA" || strOpcaoJogador == "TESOURA" && strOpcaoComputador == "PAPEL")
      Console.WriteLine("\nVocê venceu!");

    else
      Console.WriteLine("\nO computador venceu!");
  }

  static bool DesejaContinuar()
  {
    Console.Write("Deseja jogar novamente? [S/N] ");
    string? opcaoEscolhida = Console.ReadLine()?.ToUpper();

    if (opcaoEscolhida != "S")
      return false;

    return true;
  }
}