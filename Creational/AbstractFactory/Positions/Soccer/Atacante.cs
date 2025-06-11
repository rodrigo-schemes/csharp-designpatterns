namespace csharp_designpatterns.Creational.AbstractFactory.Positions.Soccer;

public class Atacante(string playerName) : IPosition
{
    public string PlayerName { get; } = playerName;
    public string GetRole() => "Atacante";
}