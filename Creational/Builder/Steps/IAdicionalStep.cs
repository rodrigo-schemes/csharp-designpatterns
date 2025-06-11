namespace csharp_designpatterns.Creational.Builder.Steps;

public interface IAdicionalStep
{
    IAdicionalStep ComAdicionais(params string[] adicionais);
    ILancheProntoStep SemAdicionais();
    Lanche Build();
}