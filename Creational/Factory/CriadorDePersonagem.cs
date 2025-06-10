namespace csharp_designpatterns.Creational.Factory;

public abstract class CriadorDePersonagem
{
    public abstract IPersonagem CriarPersonagem();

    public void EntrarNoJogo()
    {
        var personagem = CriarPersonagem();
        Console.WriteLine("\nPersonagem criado! Preparando para a batalha...");
        personagem.Atacar();
    }
}