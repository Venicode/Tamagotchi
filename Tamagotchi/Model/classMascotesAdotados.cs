class MascotesAdotados {

    public List<string> Mascotes { get; set; }

    public void AdotarMascotes(string mascote)
    {
        Mascotes.Add(mascote);
    }
    public void MostrarMascotesAdotados()
    {
        Console.Beep();
        Console.Clear();
        Console.WriteLine("Mascotes adotados:");
        foreach (var item in Mascotes)
        {
            Console.WriteLine(item);

        }
    }
}
