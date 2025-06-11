namespace csharp_designpatterns.Creational.AbstractFactory.Positions.Basketball;

public class Armador(string playerName) : IPosition
{
    public string PlayerName { get; } = playerName;

    public string GetRole() => "Armador";
}