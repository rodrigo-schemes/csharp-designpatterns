namespace csharp_designpatterns.Creational.FactoryMethod;

public class FactoryMethodDemo : IPatternDemo
{
    public string Name => "Factory Method";
    
    public Task ExecuteAsync()
    {
        CriadorDeJogo.Execute();
        return Task.CompletedTask;
    }
}