namespace csharp_designpatterns.Creational.FactoryMethod.Personagens;

public class CriadorDeMago : CriadorDePersonagem
{
    protected override IPersonagem CriarPersonagem()
    {
        return new Mago();
    }
}