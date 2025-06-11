using csharp_designpatterns.Creational.AbstractFactory.Positions.Volleyball;

namespace csharp_designpatterns.Creational.AbstractFactory.Factories;

public class VolleyballTeamFactory(string teamName) : ITeamFactory
{
    public string TeamName { get; } = teamName;

    public string GetSportName() => "Volleyball";

    public List<IPosition> CreateTeam()
    {
        return
        [
            new Levantadora("Dani Lins"),
            new Oposta("Sheilla Castro"),
            new Ponteira("Jaqueline"),
            new Ponteira("Fernanda Garay"),
            new Central("Thaisa"),
            new Central("Fabiana"),
            new Libero("Fabi")
        ];
    }
}