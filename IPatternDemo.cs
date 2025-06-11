namespace csharp_designpatterns;

public interface IPatternDemo
{
    string Name { get; }
    Task ExecuteAsync();
}