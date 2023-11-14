using Newtonsoft.Json;
using RestSharp;

class Mascote
{
    public string Name { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public List<Abilities> Abilities { get; set; }

    public void ExibirPokemons()
    {
        Console.Beep();
        Console.Clear();
        //Listando espécies Pokémon
        Console.WriteLine("     Pokémons para adoção:");
        var client = new RestClient($"https://pokeapi.co/api/v2/pokemon-species/");
        var request = new RestRequest("", Method.Get);
        var response = client.Execute(request);
        var especiesPokemons = JsonConvert.DeserializeObject<Species>(response.Content);

        for (int i = 1; i < especiesPokemons.Results.Count; i++)
        {
            Console.WriteLine($"    {i}-{especiesPokemons.Results[i].Name}");
        }

        //Com o índice da lista, acessar a API de cada Pokémon
        Console.WriteLine("\n   Escolha um Pokémon do menu para ver seus detalhes:");
        int escolha = int.Parse(Console.ReadLine()!);
        string pokemonSelecionado = especiesPokemons.Results[escolha].Name;
        var client2 = new RestClient($"https://pokeapi.co/api/v2/pokemon/{pokemonSelecionado}");
        var request2 = new RestRequest("", Method.Get);
        var response2 = client2.Execute(request2);
        var pokemon = JsonConvert.DeserializeObject<Mascote>(response2.Content);

        //Descrição do Pokémon
        Console.Beep();
        Console.Clear();
        Console.WriteLine($"    Nome: {pokemon.Name}");
        Console.WriteLine($"    Altura: {pokemon.Height}");
        Console.WriteLine($"    Peso: {pokemon.Weight}");

        for (int i = 1; i < pokemon.Abilities.Count; i++)
        {
            Console.WriteLine($"    Habilidades: {pokemon.Abilities[i].Ability.Name}");
        }
        //Em desenvolvimento:
        Console.WriteLine("\n   O que deseja fazer?\n");
        Console.WriteLine($"    1-Saber mais do {pokemon.Name}");
        Console.WriteLine($"    2-Adotar {pokemon.Name}");
        Console.WriteLine("    3-Ver outros pokémons para adoção.");
        int resposta = int.Parse(Console.ReadLine()!);
        switch (resposta) {

            case 1:
                {
                    //descricao mais detalhada do pokemon
                    Console.WriteLine("Desenvolvimento");
                    break;
                }
            case 2:
                {
                    MascotesAdotados adotar = new();
                    adotar.AdotarMascotes(pokemon.Name);
                    Console.WriteLine($"    {pokemon.Name} foi adotado! O ovo está chocando!".ToUpper());
                    Console.WriteLine(@"                                                                          
                                                
                                ████████                                  
                              ██        ██                                
                            ██▒▒▒▒        ██                              
                          ██▒▒▒▒▒▒      ▒▒▒▒██                            
                          ██▒▒▒▒▒▒      ▒▒▒▒██                            
                        ██  ▒▒▒▒        ▒▒▒▒▒▒██                          
                        ██                ▒▒▒▒██                          
                      ██▒▒      ▒▒▒▒▒▒          ██                        
                      ██      ▒▒▒▒▒▒▒▒▒▒        ██                        
                      ██      ▒▒▒▒▒▒▒▒▒▒    ▒▒▒▒██                        
                      ██▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒██                        
                        ██▒▒▒▒  ▒▒▒▒▒▒    ▒▒▒▒██                          
                        ██▒▒▒▒            ▒▒▒▒██                          
                          ██▒▒              ██                            
                            ████        ████                              
                                ████████                                  
                                                         
");
                    Console.ReadKey();
                    break;
                }
            case 3:
                {
                    ExibirPokemons();
                    break;
                }
        }
        Console.ReadKey();

    }

}
