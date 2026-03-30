using System.Security.Cryptography;

namespace PedraPapelTesoura.ConsoleApp;

class Program
{
  static void Main(string[] args)
  {

    while (true)
    {

      Console.Clear();
      Console.WriteLine("=========================================");
      Console.WriteLine("--------- Pedra, Papel e Tesoura --------");
      Console.WriteLine("=========================================");

      int opcaoJogador;
      int opcaoComputador;

      #region Jogador
      Console.WriteLine("\n---------- Rodada do Jogador ------------");
      Console.WriteLine("\n>> Sua vez de jogar!\nEscolha uma das opções abaixo:");
      Console.WriteLine("\n1 - Pedra");
      Console.WriteLine("2 - Papel");
      Console.WriteLine("3 - Tesoura");

      Console.Write("\nDigite a sua escolha: ");
      opcaoJogador = Convert.ToInt32(Console.ReadLine());

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
          Console.WriteLine("\n>> Opção inválida. Tente novamente!");
          Console.Write("Digite ENTER para continuar...");
          Console.ReadLine();
          continue;
      }

      Console.WriteLine($"\nVocê escolheu: {strOpcaoJogador}!");

      #endregion

      #region Computador
      Console.WriteLine("\n>> Agora é a vez do computador! ");
      Console.Write("Digite ENTER para continuar...");
      Console.ReadLine();

      Console.WriteLine("\n---------- Rodada do Computador ---------");

      opcaoComputador = RandomNumberGenerator.GetInt32(1, 4);

      string strOpcaoComputador;

      switch (opcaoComputador)
      {
        case 1:
          strOpcaoComputador = "PEDRA";
          break;

        case 2:
          strOpcaoComputador = "PAPEL";
          break;

        case 3:
          strOpcaoComputador = "TESOURA";
          break;

        default:
          Console.Write("\nOpção inválida! Tente novamente");
          Console.Write("Digite ENTER para continuar...");
          Console.ReadLine();
          continue;
      }

      Console.WriteLine($"\nO computador escolheu a opção: {strOpcaoComputador}");

      #endregion

      Console.WriteLine("\nDigite ENTER para ver o resultado...");
      Console.ReadLine();

      #region Lógica Vencedor

      Console.WriteLine("---------- Resultado da Rodada -----------");

      if (strOpcaoJogador == strOpcaoComputador)
        Console.WriteLine("\n>> Empate!");

      else if (strOpcaoJogador == "PEDRA" && strOpcaoComputador == "TESOURA" || strOpcaoJogador == "PAPEL" && strOpcaoComputador == "PEDRA" || strOpcaoJogador == "TESOURA" && strOpcaoComputador == "PAPEL")
        Console.WriteLine("\n>> Parabéns! Você venceu :)");

      else
        Console.WriteLine("\n>> Que pena! O computador venceu :(");

      #endregion

      Console.Write("\nDeseja jogar novamente? [S/N] --> ");
      string? opcaoEscolhida = Console.ReadLine()?.ToUpper();

      if (opcaoEscolhida != "S")
        break;

    }

    Console.ReadLine();
  }
}
