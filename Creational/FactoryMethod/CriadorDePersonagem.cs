namespace csharp_designpatterns.Creational.FactoryMethod;

public abstract class CriadorDePersonagem
{
    protected abstract IPersonagem CriarPersonagem();

    public void EntrarNoJogo()
    {
        var personagem = CriarPersonagem();
        Console.WriteLine("\nPersonagem criado! Preparando para a batalha...");
        personagem.Atacar();
    }
}