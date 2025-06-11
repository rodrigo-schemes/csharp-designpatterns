namespace csharp_designpatterns.Creational.AbstractFactory.Positions.Soccer;

public class MeioCampo(string playerName) : IPosition
{
    public string PlayerName { get; } = playerName;
    public string GetRole() => "Meia";
}