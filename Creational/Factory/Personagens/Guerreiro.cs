namespace csharp_designpatterns.Creational.Factory.Personagens;

public class Guerreiro : IPersonagem
{
    public void Atacar()
    {
        Console.WriteLine("O Guerreiro ataca com sua espada!");
    }
}