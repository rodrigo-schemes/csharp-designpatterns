namespace csharp_designpatterns.Creational.AbstractFactory.Positions.Basketball;

public class Ala(string playerName) : IPosition
{
    public string PlayerName { get; } = playerName;
    public string GetRole() => "Ala";
}