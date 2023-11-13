//Tamagotchi API Rest Pokemon

//https://pokeapi.co/api/v2/pokemon/{id or name}/
//https://pokeapi.co/api/v2/pokemon-species/

using RestSharp;
using Newtonsoft.Json;
class Program
{
    static void Main(string[] args)
    {
        //Menu de seleção
        Menu mostrarMenu = new Menu();
        mostrarMenu.Mensagem();

        Console.WriteLine("\nEscolha uma opção: ");
        int escolha = int.Parse(Console.ReadLine()!);

        switch (escolha)
        {
            case 1:
                {
                    Console.Clear();
                    Mascote mostrarMascote = new();
                    mostrarMascote.ExibirPokemons();
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Opção ainda em desenvolvimento.");
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Até logo!");
                    Console.ReadKey();
                    break;
                }

        }

    }

}


