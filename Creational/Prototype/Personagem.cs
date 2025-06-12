namespace csharp_designpatterns.Creational.Prototype;

public class Personagem : ICloneable
{
    public required string Nome { get; init; }
    public required string EraHistorica { get; set; }
    public required Equipamento Equipamento { get; init; }
    public required int PoderDeAtaque { get; set; }
    
    public object Clone()
    {
        return new Personagem
        {
            Nome = Nome,
            EraHistorica = EraHistorica,
            Equipamento = Equipamento.Clone(),
            PoderDeAtaque = PoderDeAtaque
        };
    }
    
    public void Exibir()
    {
        Console.WriteLine($"\n{Nome} - Era: {EraHistorica}");
        Console.WriteLine($"  Arma: {Equipamento.Arma}");
        Console.WriteLine($"  Armadura: {Equipamento.Armadura}");
        Console.WriteLine($"  Poder de Ataque: {PoderDeAtaque}");
    }
    
    public Personagem EvoluirParaNovaEra(string novaEra, string novaArma, string novaArmadura)
    {
        var clone = (Personagem) Clone();
        clone.EraHistorica = novaEra;
        clone.Equipamento.Arma = novaArma;
        clone.Equipamento.Armadura = novaArmadura;
        clone.PoderDeAtaque *= 2;
        
        return clone;
    }
}