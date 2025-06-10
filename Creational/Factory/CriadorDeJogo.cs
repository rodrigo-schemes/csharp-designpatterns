using csharp_designpatterns.Creational.Factory.Personagens;

namespace csharp_designpatterns.Creational.Factory;

public static class CriadorDeJogo
{
    public static void Executar()
    {
        Console.WriteLine("Escolha seu personagem: " +
                          "\n 1. Guerreiro" +
                          "\n 2. Arqueiro" +
                          "\n 3. Mago");
        
        Console.Write("\nOpção: ");
        var personagemEscolhido = Console.ReadLine();
        CriadorDePersonagem? criadorDePersonagem;

        switch (personagemEscolhido)
        {
            case "1":
                criadorDePersonagem = new CriadorDeGuerreiro();
                break;
            case "2":
                criadorDePersonagem = new CriadorDeArqueiro();
                break;
            case "3":
                criadorDePersonagem = new CriadorDeMago();
                break;
            default:
                Console.WriteLine("Personagem inválido!");
                return;
        }
        
        criadorDePersonagem.EntrarNoJogo();
    }
}