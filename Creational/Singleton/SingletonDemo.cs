namespace csharp_designpatterns.Creational.Singleton;

public class SingletonDemo : IPatternDemo
{
    public string Name => "Singleton";
    
    public async Task ExecuteAsync()
    {
        await PlacarGlobal.Instancia.ExecuteAsync();
    }
}