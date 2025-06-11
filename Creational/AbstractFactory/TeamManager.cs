using csharp_designpatterns.Creational.AbstractFactory.Factories;

namespace csharp_designpatterns.Creational.AbstractFactory;

public class TeamManager(ITeamFactory factory)
{
    private void ShowTeam()
    {
        Console.WriteLine($"Esporte: {factory.GetSportName()}");
        Console.WriteLine($"Time: {factory.TeamName}");
        Console.WriteLine("Formação:");
        
        var team = factory.CreateTeam();

        foreach (var position in team)
        {
            Console.WriteLine($"- {position.GetRole()}: {position.PlayerName}");
        }
        
        Console.WriteLine();
    }
    
    public static void Execute()
    {
        Console.WriteLine("Escolha o esporte para montar o time: " +
                          "\n 1. Futebol" +
                          "\n 2. Basquete" +
                          "\n 3. Volleyball");

        Console.Write("\nOpção: ");
        var escolha = Console.ReadLine();

        ITeamFactory? teamFactory;

        switch (escolha)
        {
            case "1":
                teamFactory = new SoccerTeamFactory("Palmeiras 2025");
                break;
            case "2":
                teamFactory = new BasketballTeamFactory("USA 2024");
                break;
            case "3":
                teamFactory = new VolleyballTeamFactory("Brasil Feminino 2012");
                break;
            default:
                Console.WriteLine("Esporte inválido!");
                return;
        }

        var manager = new TeamManager(teamFactory);
        manager.ShowTeam();
    }
}