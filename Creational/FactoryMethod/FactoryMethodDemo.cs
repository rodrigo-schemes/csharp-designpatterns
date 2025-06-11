namespace csharp_designpatterns.Creational.FactoryMethod;

public class FactoryMethodDemo : IPatternDemo
{
    public string Name => "Factory Method";
    
    public Task ExecuteAsync()
    {
        Console.WriteLine("\n--- Executando Factory Method ---\n");
        CriadorDeJogo.Execute();
        return Task.CompletedTask;
    }
}