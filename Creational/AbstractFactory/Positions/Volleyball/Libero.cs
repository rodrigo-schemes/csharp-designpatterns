namespace csharp_designpatterns.Creational.AbstractFactory.Positions.Volleyball;

public class Libero(string playerName) : IPosition
{
    public string PlayerName { get; } = playerName;

    public string GetRole() => "Libero";
    
}