namespace csharp_designpatterns.Creational.Prototype;

public class PrototypeDemo : IPatternDemo
{
    public string Name => "Prototype";
    public Task ExecuteAsync()
    {
        var personagem = new Personagem
        {
            Nome = "Herói",
            EraHistorica = "Pré-História",
            Equipamento = new Equipamento("Tacape de Pedra", "Peles de Bicho"),
            PoderDeAtaque = 1
        };

        var eraAntiga = personagem.EvoluirParaNovaEra("Idade Antiga", "Lança de Bronze", "Túnica de Linho");
        var idadeMedia = eraAntiga.EvoluirParaNovaEra("Idade Média", "Espada Longa", "Armadura de Aço");
        var idadeModerna = idadeMedia.EvoluirParaNovaEra("Idade Moderna", "Mosquete", "Casaco de Couro");
        var idadeContemporanea = idadeModerna.EvoluirParaNovaEra("Idade Contemporânea", "Rifle de Precisão", "Colete Tático");
        
        personagem.Exibir();
        eraAntiga.Exibir();
        idadeMedia.Exibir();
        idadeModerna.Exibir();
        idadeContemporanea.Exibir();
        
        return Task.CompletedTask;
    }
}