namespace csharp_designpatterns.Creational.Builder;

public class Lanche
{
    public string Pao { get; set; }
    public string Carne { get; set; }
    public List<string> Adicionais { get; set; } = new();

    public override string ToString()
    {
        var adicionais = Adicionais.Any() ? string.Join(", ", Adicionais) : "sem adicionais";
        return $"Lanche com {Pao}, {Carne}, adicionais: {adicionais}";
    }
}