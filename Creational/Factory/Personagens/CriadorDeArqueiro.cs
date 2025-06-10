namespace csharp_designpatterns.Creational.Factory.Personagens;

public class CriadorDeArqueiro : CriadorDePersonagem
{
    public override IPersonagem CriarPersonagem()
    {
        return new Arqueiro();
    }
}