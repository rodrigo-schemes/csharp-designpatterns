using csharp_designpatterns.Creational.Builder.Steps;

namespace csharp_designpatterns.Creational.Builder;

public class LancheBuilder : IPaoStep, ICarneStep, IAdicionalStep, ILancheProntoStep
{
    private Lanche _lanche = new();

    private LancheBuilder() {}

    public static IPaoStep Criar() => new LancheBuilder();

    public ICarneStep ComPao(string tipoPao)
    {
        _lanche.Pao = tipoPao;
        return this;
    }

    public IAdicionalStep ComCarne(string tipoCarne)
    {
        _lanche.Carne = tipoCarne;
        return this;
    }

    public IAdicionalStep ComAdicionais(params string[] adicionais)
    {
        _lanche.Adicionais.AddRange(adicionais);
        return this;
    }

    public ILancheProntoStep SemAdicionais() => this;
    Lanche IAdicionalStep.Build() => _lanche;

    public Lanche Build() => _lanche;
}
