namespace csharp_designpatterns.Creational.Factory.Personagens;

public class CriadorDeMago : CriadorDePersonagem
{
    public override IPersonagem CriarPersonagem()
    {
        return new Mago();
    }
}