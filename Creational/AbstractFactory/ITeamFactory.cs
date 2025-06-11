namespace csharp_designpatterns.Creational.AbstractFactory;

public interface ITeamFactory
{
    string TeamName { get; }
    string GetSportName();
    List<IPosition> CreateTeam();
}