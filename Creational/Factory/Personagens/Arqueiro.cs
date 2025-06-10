namespace csharp_designpatterns.Creational.Factory.Personagens;

public class Arqueiro : IPersonagem
{
    public void Atacar()
    {
        Console.WriteLine("O Arqueiro dispara uma flecha precisa!");
    }
}