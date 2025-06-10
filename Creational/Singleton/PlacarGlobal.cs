using System.Collections.Concurrent;

namespace csharp_designpatterns.Creational.Singleton;

public sealed class PlacarGlobal
{
    private static readonly Lazy<PlacarGlobal> _instancia = new(() => new PlacarGlobal());

    private int _pontosDisponiveis = 500;
    private static readonly Lock _lock = new();

    private readonly ConcurrentDictionary<int, int> _pontuacaoJogadores = new();

    private PlacarGlobal() { }

    public static PlacarGlobal Instancia => _instancia.Value;

    /// <summary>
    /// Tenta retirar de 1 a 10 pontos do total disponível para o jogador especificado.
    /// A quantidade retirada é aleatória e limitada pela quantidade restante de pontos.
    /// Retorna true se o jogador conseguiu pegar pontos; false se não houver mais pontos disponíveis.
    /// </summary>
    private bool ObterPontos(int jogadorId)
    {
        // Garante que apenas uma thread por vez execute esse trecho crítico
        lock (_lock)
        {
            // Se não houver mais pontos disponíveis, a jogada falha
            if (_pontosDisponiveis <= 0)
                return false;

            // Cria um gerador de número aleatório com uma semente única, para evitar repetição entre threads
            var numeroRandomico = new Random(Guid.NewGuid().GetHashCode());

            // Sorteia a quantidade de pontos da jogada: de 1 até o menor valor entre 10 ou os pontos restantes
            var pontosNaJogada = numeroRandomico.Next(1, Math.Min(10, _pontosDisponiveis) + 1);

            // Subtrai a quantidade sorteada dos pontos disponíveis
            _pontosDisponiveis -= pontosNaJogada;

            // Atualiza a pontuação do jogador no dicionário concorrente
            // Se for a primeira vez do jogador, inicia com pontosNaJogada
            // Caso contrário, soma aos pontos que ele já tinha
            _pontuacaoJogadores.AddOrUpdate(
                jogadorId,
                pontosNaJogada,
                (_, pontuacaoAtual) => pontuacaoAtual + pontosNaJogada
            );

            // Exibe no console o resultado da jogada
            Console.WriteLine($"### Jogador {jogadorId} pegou {pontosNaJogada} pontos. Restantes: {_pontosDisponiveis} ###");

            // Indica que o jogador conseguiu pegar pontos
            return true;
        }
    }

    public async Task ExecutarAsync()
    {
        Console.WriteLine("### Iniciando partida! ###");

        // Lista que vai guardar todas as tarefas (threads) dos jogadores
        var tasks = new List<Task>();
        const int totalPlayers = 5;

        // Cria uma tarefa para cada jogador
        for (var i = 1; i <= totalPlayers; i++)
        {
            var jogadorId = i;

            // Adiciona uma nova tarefa (thread) para representar o jogador
            tasks.Add(Task.Run(async () =>
            {
                // Criador de número aleatório para definir o tempo entre jogadas
                var tempoEntreJogadas = new Random(Guid.NewGuid().GetHashCode());

                // Enquanto ainda for possível obter pontos, o jogador continua jogando
                while (true)
                {
                    // Tenta obter pontos (de 1 a 10 aleatoriamente)
                    var conseguiu = ObterPontos(jogadorId);

                    // Se não conseguiu pegar pontos, sai do loop
                    if (!conseguiu) break;

                    // Aguarda um tempo aleatório entre 100 e 500ms antes da próxima jogada
                    await Task.Delay(tempoEntreJogadas.Next(100, 500));
                }

                // Informa que o jogador finalizou suas jogadas
                Console.WriteLine($"### Jogador {jogadorId} terminou. ###");
            }));
        }

        // Aguarda até que todos os jogadores terminem suas jogadas
        await Task.WhenAll(tasks);

        // Exibe o ranking final dos jogadores, ordenado por pontuação (maior para menor)
        Console.WriteLine("\n ### Ranking Final: ###");
        var ranking = _pontuacaoJogadores
            .OrderByDescending(p => p.Value)
            .ToList();

        // Exibe cada jogador com sua posição e pontuação
        for (var pos = 0; pos < ranking.Count; pos++)
        {
            var (jogadorId, pontuacao) = ranking[pos];
            Console.WriteLine($"#{pos + 1} - Jogador {jogadorId} : {pontuacao} pontos");
        }

        // Mostra o total de pontos que foram distribuídos entre os jogadores
        var totalDistribuido = _pontuacaoJogadores.Values.Sum();
        Console.WriteLine($"\n ### Pontos distribuídos: {totalDistribuido}/500 ###");
    }

}