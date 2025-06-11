namespace csharp_designpatterns.Creational.FactoryMethod.Personagens;

public class Mago : IPersonagem
{
    public void Atacar()
    {
        Console.WriteLine("O Mago lança uma bola de fogo!");
    }
}