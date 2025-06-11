namespace csharp_designpatterns.Creational.AbstractFactory.Positions.Soccer;

public class Zagueiro(string playerName) : IPosition
{
    public string PlayerName { get; } = playerName;
    public string GetRole() => "Zagueiro";
}