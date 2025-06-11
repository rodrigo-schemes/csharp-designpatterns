namespace csharp_designpatterns.Creational.FactoryMethod.Personagens;

public class Arqueiro : IPersonagem
{
    public void Atacar()
    {
        Console.WriteLine("O Arqueiro dispara uma flecha precisa!");
    }
}