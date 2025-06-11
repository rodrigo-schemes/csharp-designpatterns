namespace csharp_designpatterns.Creational.Builder.Steps;

public interface IPaoStep
{
    ICarneStep ComPao(string tipoPao);
}