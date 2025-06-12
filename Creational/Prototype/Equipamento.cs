namespace csharp_designpatterns.Creational.Prototype;

public class Equipamento(string arma, string armadura)
{
    public string Arma { get; set; } = arma;
    public string Armadura { get; set; } = armadura;

    public Equipamento Clone()
    {
        return new Equipamento(Arma, Armadura)
        {
            Arma = Arma,
            Armadura = Armadura
        };
    }
}