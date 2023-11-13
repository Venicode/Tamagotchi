class Menu
{
    public string NomeUsuario { get; set; }

    public List<string> opcoes = new();

    public void MostrarMenu()
    {
        opcoes.Add("1-Adoção de mascotes");
        opcoes.Add("2-Ver mascotes adotados");
        opcoes.Add("3-Sair do jogo");

        foreach (var opco in opcoes)
        {
            Console.WriteLine(opco);
        }

    }
    public void Mensagem()
    {
        Console.WriteLine(@"
████████╗ █████╗ ███╗   ███╗ █████╗  ██████╗  ██████╗ ████████╗ ██████╗██╗  ██╗██╗
╚══██╔══╝██╔══██╗████╗ ████║██╔══██╗██╔════╝ ██╔═══██╗╚══██╔══╝██╔════╝██║  ██║██║
   ██║   ███████║██╔████╔██║███████║██║  ███╗██║   ██║   ██║   ██║     ███████║██║
   ██║   ██╔══██║██║╚██╔╝██║██╔══██║██║   ██║██║   ██║   ██║   ██║     ██╔══██║██║
   ██║   ██║  ██║██║ ╚═╝ ██║██║  ██║╚██████╔╝╚██████╔╝   ██║   ╚██████╗██║  ██║██║
   ╚═╝   ╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝    ╚═╝    ╚═════╝╚═╝  ╚═╝╚═╝");
        Console.WriteLine("Olá, seja bem vindo(a) ao Tamagotchi!\n");
        Console.WriteLine("Aqui voce irá poder adotar " +
            "mascotes e cuidar dos seus bichinhos!");
        Console.WriteLine("Prazer em conhecer você, como posso te chamar?");
        NomeUsuario = Console.ReadLine()!;
        Console.WriteLine($"Certo {NomeUsuario}! O que deseja fazer hoje?\n");
        MostrarMenu();
    }

}