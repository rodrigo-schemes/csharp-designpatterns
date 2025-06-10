
# 🎮 Singleton e Concorrência em C# — Um Joguinho pra Aprender de Verdade

Fiz esse exemplo pra entender melhor como o padrão **Singleton** funciona na prática e como lidar com concorrência em C#. A ideia foi criar uma simulação de um jogo onde vários jogadores disputam uma pontuação limitada. No caminho, explorei técnicas de sincronização e execução paralela.

---

## 🔄 O que é Singleton, afinal?

O Singleton é um padrão de projeto que garante que uma classe tenha **apenas uma instância** durante toda a execução do programa.

### Por que usar isso?
- É útil quando precisamos de **um ponto centralizado de controle**, como um serviço de log, um gerenciador de configuração ou — no nosso caso — uma pontuação global.
- Evita instanciar objetos repetidamente sem necessidade.
- Garante que todo mundo (todas as threads, inclusive) estejam olhando pro mesmo objeto.

No meu código usei `Lazy<T>` pra deixar isso **thread-safe** e garantir que a instância só seja criada quando for realmente usada.

```csharp
public sealed class PlacarGlobal
{
    private static readonly Lazy<GlobalScore> _instancia = new(() => new PlacarGlobal());
    public static PlacarGlobal Instancia => _instancia.Value;

    private PlacarGlobal() { }
}
```

---

## 🕹️ O jogo: como funciona?

- Temos 500 pontos no total.
- 5 jogadores jogam ao mesmo tempo, cada um numa thread (ou Task).
- A cada jogada, o jogador tenta pegar entre **1 e 10 pontos aleatoriamente**.
- Quando os pontos acabam, o jogo termina e mostramos o ranking final.

---

## ⚙️ Como fiz funcionar direitinho (sem bugs de concorrência)

### 1. `lock` para proteger a pontuação

Como todos os jogadores acessam e alteram os mesmos dados (pontuação total e placar), usei um `lock` pra evitar bagunça:

```csharp
lock (_lock)
{
    // Acesso seguro
}
```

Isso garante que **só uma thread por vez** consiga pegar pontos.

### 2. Um cuidado com o `Random`

Se você usar `new Random()` direto em várias threads, pode acabar com números repetidos. Resolvi isso gerando a semente com `Guid.NewGuid().GetHashCode()`. Assim cada thread tem um gerador único:

```csharp
var rng = new Random(Guid.NewGuid().GetHashCode());
```

### 3. Execução concorrente com `Task.Run`

Cada jogador roda numa `Task`, e eu espero todas terminarem com `Task.WhenAll`. Simples e eficiente.

```csharp
var tasks = new List<Task>();

for (var i = 1; i <= 5; i++)
{
    var jogadorId = i;
    tasks.Add(Task.Run(async () => {
        while (ObterPontos(jogadorId))
            await Task.Delay(rng.Next(100, 500));
    }));
}

await Task.WhenAll(tasks);
```

### 4. Ranking final com `ConcurrentDictionary`

Usei um `ConcurrentDictionary` pra armazenar o placar de cada jogador. Ele já é thread-safe, então não precisei de mais `lock` pra isso.

---

## 🏁 Resultado típico

```plaintext
### Iniciando partida! ###
### Jogador 1 pegou 8 pontos. Restantes: 492 ###
...
### Jogador 3 terminou. ###

### Ranking Final: ###
#1 - Jogador 4 : 142 pontos
#2 - Jogador 2 : 129 pontos
#3 - Jogador 1 : 113 pontos
#4 - Jogador 5 : 74 pontos
#5 - Jogador 3 : 42 pontos

### Pontos distribuídos: 500/500 ###
```

---

## 💭 O que eu aprendi com isso

- Singleton com `Lazy<T>` é super simples e seguro.
- Concorrência em C# não precisa ser um bicho de sete cabeças se você usar `lock` e `Task` com cuidado.
- E dá pra se divertir criando um joguinho simples e ver os conceitos funcionando na prática.

Se quiser, dá pra adaptar esse mesmo código pra outras situações onde vários processos disputam um recurso limitado.

---
