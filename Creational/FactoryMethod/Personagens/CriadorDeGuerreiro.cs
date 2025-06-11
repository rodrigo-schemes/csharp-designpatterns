namespace csharp_designpatterns.Creational.FactoryMethod.Personagens;

public class CriadorDeGuerreiro : CriadorDePersonagem
{
    protected override IPersonagem CriarPersonagem()
    {
        return new Guerreiro();
    }
}