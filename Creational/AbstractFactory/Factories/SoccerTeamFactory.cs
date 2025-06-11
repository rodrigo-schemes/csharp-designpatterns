using csharp_designpatterns.Creational.AbstractFactory.Positions.Soccer;

namespace csharp_designpatterns.Creational.AbstractFactory.Factories;

public class SoccerTeamFactory(string teamName) : ITeamFactory
{
    public string TeamName { get; } = teamName;
    public string GetSportName() => "Futebol";

    public List<IPosition> CreateTeam()
    {
        return
        [
            new Goleiro("Weverton"),
            new Zagueiro("Giay"),
            new Zagueiro("Murilo"),
            new Zagueiro("Gustavo Gomez"),
            new Zagueiro("Piquerez"),
            new MeioCampo("Martinez"),
            new MeioCampo("Richard Rios"),
            new MeioCampo("Rafael Veiga"),
            new Atacante("Estevao"),
            new Atacante("Vitor Roque"),
            new Atacante("Facundo Torres")
        ];
    }
}