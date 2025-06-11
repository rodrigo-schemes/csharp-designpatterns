namespace csharp_designpatterns.Creational.AbstractFactory;

public class AbstractFactoryDemo : IPatternDemo
{
    public string Name => "Abstract Factory";
    
    public Task ExecuteAsync()
    {
        Console.WriteLine("\n--- Executando Abstract Factory ---\n");
        TeamManager.Execute();
        return Task.CompletedTask;
    }
}