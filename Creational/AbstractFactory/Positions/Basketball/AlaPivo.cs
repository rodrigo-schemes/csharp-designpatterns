namespace csharp_designpatterns.Creational.AbstractFactory.Positions.Basketball;

public class AlaPivo(string playerName) : IPosition
{
    public string PlayerName { get; } = playerName;

    public string GetRole() => "Ala Pivo";
}