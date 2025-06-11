namespace csharp_designpatterns.Creational.FactoryMethod.Personagens;

public class Guerreiro : IPersonagem
{
    public void Atacar()
    {
        Console.WriteLine("O Guerreiro ataca com sua espada!");
    }
}