namespace csharp_designpatterns.Creational.FactoryMethod.Personagens;

public class CriadorDeArqueiro : CriadorDePersonagem
{
    protected override IPersonagem CriarPersonagem()
    {
        return new Arqueiro();
    }
}