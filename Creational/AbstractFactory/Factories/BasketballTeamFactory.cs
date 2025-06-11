using csharp_designpatterns.Creational.AbstractFactory.Positions.Basketball;

namespace csharp_designpatterns.Creational.AbstractFactory.Factories;

public class BasketballTeamFactory(string teamName) : ITeamFactory
{
    public string TeamName { get; }  = teamName;
    public string GetSportName() => "Basketball";
    
    public List<IPosition> CreateTeam()
    {
        return
        [
            new Armador("Stephen Curry"),
            new AlaArmador("Devin Booker"),
            new Ala("LeBron James"),
            new AlaPivo("Kevin Durant"),
            new Pivo("Joel Embiid")
        ];
    }
}