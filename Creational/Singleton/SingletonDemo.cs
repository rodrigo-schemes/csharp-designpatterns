namespace csharp_designpatterns.Creational.Singleton;

public class SingletonDemo : IPatternDemo
{
    public string Name => "Singleton";
    
    public async Task ExecuteAsync()
    {
        Console.WriteLine("\n--- Executando Singleton ---\n");
        await PlacarGlobal.Instancia.ExecuteAsync();
    }
}