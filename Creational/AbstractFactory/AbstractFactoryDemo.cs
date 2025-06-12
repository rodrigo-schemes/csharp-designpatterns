namespace csharp_designpatterns.Creational.AbstractFactory;

public class AbstractFactoryDemo : IPatternDemo
{
    public string Name => "Abstract Factory";
    
    public Task ExecuteAsync()
    {
        TeamManager.Execute();
        return Task.CompletedTask;
    }
}