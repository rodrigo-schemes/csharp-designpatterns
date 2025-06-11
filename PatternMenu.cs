using csharp_designpatterns.Creational.AbstractFactory;
using csharp_designpatterns.Creational.FactoryMethod;
using csharp_designpatterns.Creational.Singleton;

namespace csharp_designpatterns;

public static class PatternMenu
{
    private static readonly List<IPatternDemo> Patterns =
    [
        new SingletonDemo(),
        new FactoryMethodDemo(),
        new AbstractFactoryDemo()
    ];

    public static async Task ShowAsync()
    {
        var sair = false;

        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("=== Design Patterns ===");

            for (var i = 0; i < Patterns.Count; i++)
                Console.WriteLine($"{i + 1}. {Patterns[i].Name}");

            Console.WriteLine("0. Sair");
            Console.Write("\nOpção: ");
            var input = Console.ReadLine();

            if (input == "0")
            {
                sair = true;
                Console.WriteLine("Saindo...");
                continue;
            }

            if (int.TryParse(input, out var index) &&
                index >= 1 && index <= Patterns.Count)
            {
                var pattern = Patterns[index - 1];
                await pattern.ExecuteAsync();
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

            if (sair) continue;
            
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}