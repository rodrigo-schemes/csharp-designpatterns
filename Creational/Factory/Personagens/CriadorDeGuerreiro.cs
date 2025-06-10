namespace csharp_designpatterns.Creational.Factory.Personagens;

public class CriadorDeGuerreiro : CriadorDePersonagem
{
    public override IPersonagem CriarPersonagem()
    {
        return new Guerreiro();
    }
}