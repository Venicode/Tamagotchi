using Newtonsoft.Json;
using RestSharp;

class Mascote
{
    public string Name { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public List<Abilities> Abilities { get; set; }
}
