using System.Collections.Generic;

class Controller
{

    private Menu Menu { get; set; }
    private APIPokemon APIPokemon { get; set; }
    private List<Results> Especies { get; set; }
    private List<Mascote> MascotesAdotados { get; set; }

    public Controller()
    {
        Menu = new Menu();
        APIPokemon = new APIPokemon();
        Especies = APIPokemon.BuscarEspeciesPokemons();
        MascotesAdotados = new List<Mascote>();
    }

    public void Play()
    {
        Menu.Mensagem();
        while(true)
        {
            Menu.MostrarMenu();
            int escolha = int.Parse(Console.ReadLine()!);
            switch (escolha)
            {
                case 1:
                    {
                        Console.Clear();
                        Menu.MostrarPokemonsDisponiveis(Especies);
                        string especiePokemon = Menu.EscolherPokemon(Especies);
                        Mascote pokemonObj = APIPokemon.BuscarDetalhesPokemons(especiePokemon);
                        Menu.MostrarDetalhesPokemons(pokemonObj);
                        //Em desenvolvimento:
                        Console.WriteLine("\n   O que deseja fazer?\n");
                        Console.WriteLine($"    1-Saber mais do {especiePokemon}");
                        Console.WriteLine($"    2-Adotar {especiePokemon}");
                        Console.WriteLine("    3-Ver outros pokémons para adoção.");
                        int resposta = int.Parse(Console.ReadLine()!);
                        switch (resposta)
                        {

                            case 1:
                                {
                                    //descricao mais detalhada do pokemon
                                    Console.WriteLine("Desenvolvimento");
                                    break;
                                }
                            case 2:
                                {
                                    MascotesAdotados adotar = new();
                                    adotar.AdotarMascotes(pokemonObj);
                                    Console.WriteLine($"    {especiePokemon} foi adotado! O ovo está chocando!".ToUpper());
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
                                    Menu.MostrarPokemonsDisponiveis(Especies);
                                    break;
                                }
                        }
                        Console.ReadKey();

                        break;
                    }
                case 2:
                    {
                        MascotesAdotados mostrarMascotes = new();
                        mostrarMascotes.MostrarMascotesAdotados();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Até logo!");
                        Console.ReadKey();
                        break;
                    }

            }
            Console.WriteLine("teste");
        }
    }

}


