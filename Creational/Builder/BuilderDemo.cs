namespace csharp_designpatterns.Creational.Builder;

public class BuilderDemo : IPatternDemo
{
    public string Name => "Builder";
    public Task ExecuteAsync()
    {
        Console.WriteLine("Bem-vindo à Lanchonete!");
        Console.WriteLine("Escolha o lanche:");
        Console.WriteLine("1 - X-Salada");
        Console.WriteLine("2 - X-Burger");
        Console.WriteLine("3 - HotDog");
        Console.Write("Sua escolha: ");

        var escolha = Console.ReadLine();
        var lanche = escolha switch
        {
            "1" => MontarXSalada(),
            "2" => MontarXBurger(),
            "3" => MontarHotDog(),
            _ => throw new Exception("Opção inválida!")
        };

        Console.WriteLine($"\n Lanche montado: {lanche}");
        return Task.CompletedTask;
    }

    private static Lanche MontarXSalada() =>
        LancheBuilder.Criar()
            .ComPao("Pão de hambúrguer")
            .ComCarne("Carne bovina")
            .ComAdicionais("Alface", "Tomate", "Queijo")
            .Build();

    private static Lanche MontarXBurger() =>
        LancheBuilder.Criar()
            .ComPao("Pão de hambúrguer")
            .ComCarne("Carne bovina")
            .ComAdicionais("Queijo")
            .Build();

    private static Lanche MontarHotDog() =>
        LancheBuilder.Criar()
            .ComPao("Pão de hotdog")
            .ComCarne("Salsicha")
            .ComAdicionais("Ketchup", "Mostarda", "Batata palha")
            .Build();
}