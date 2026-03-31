namespace PedraPapelTesoura.ConsoleApp;

class Program
{
  static void Main(string[] args)
  {

    Iniciar();

  }

  static void Iniciar()
  {
    while (true)
    {
      ExibirCabecalho();

      Console.WriteLine("\n------------Rodada do Jogador------------");
      Jogador.ExecutarRodada();

      Console.WriteLine("\n----------Rodada do Computador-----------");
      string strOpcaoComputador = Computador.ExecutarRodada();

      Console.WriteLine("\nDigite ENTER para ver o resultado...");
      Console.ReadLine();

      Console.WriteLine("----------Resultado da Rodada-----------");
      Jogador.Ganhou(strOpcaoComputador);

      if (!Jogador.DesejaContinuar())
        break;
    }
  }
  static void ExibirCabecalho()
  {
    Console.Clear();
    Console.WriteLine("=========================================");
    Console.WriteLine("----------Pedra, Papel e Tesoura---------");
    Console.WriteLine("=========================================");
  }
}