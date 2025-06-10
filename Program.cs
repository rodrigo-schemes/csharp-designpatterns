using csharp_designpatterns.Creational.Factory;
using csharp_designpatterns.Creational.Singleton;

var sair = false;

while (!sair)
{
    Console.Clear();
    Console.WriteLine("=== Design Patterns ===");
    Console.WriteLine("Escolha um padrão para testar:");
    Console.WriteLine("1. Singleton");
    Console.WriteLine("2. Factory Method");
    Console.WriteLine("0. Sair");
    Console.Write("\nOpção: ");
    
    var opcao = Console.ReadLine();
    
    switch (opcao)
    {
        case "1":
            Console.WriteLine("\n--- Executando Singleton ---\n");
            await PlacarGlobal.Instancia.ExecutarAsync();
            break;
            
        case "2":
            Console.WriteLine("\n--- Executando Factory Method ---\n");
            CriadorDeJogo.Executar();
            break;
            
        case "0":
            sair = true;
            Console.WriteLine("Saindo...");
            break;
            
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    if (!sair)
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}