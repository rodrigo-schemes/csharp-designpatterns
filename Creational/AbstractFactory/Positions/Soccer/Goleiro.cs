namespace csharp_designpatterns.Creational.AbstractFactory.Positions.Soccer;

public class Goleiro(string playerName) : IPosition
{
    public string PlayerName { get; } = playerName;
    public string GetRole() => "Goleiro";
}