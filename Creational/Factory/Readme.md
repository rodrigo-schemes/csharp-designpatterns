# Padrão de Projeto: Factory Method 🎮

## 🧠 Definição

O **Factory Method** é um padrão de criação que define uma interface para criar objetos, mas permite que as subclasses decidam qual classe instanciar. Ele delega a responsabilidade da criação dos objetos para classes filhas, promovendo desacoplamento e flexibilidade.

> **Definição GoF:** "Define uma interface para criar um objeto, mas deixa as subclasses decidirem qual classe instanciar."

---

## 📌 Quando Usar

Use o padrão Factory Method quando:

- Você precisa instanciar objetos, mas quer manter o código desacoplado das classes concretas.
- Você deseja delegar a lógica de criação para subclasses.
- Você quer tornar o sistema mais extensível com novas implementações sem alterar o código existente.

---

## 🧩 Exemplo Lúdico: Jogo Medieval

### Contexto

Um jogo onde o jogador pode escolher sua classe: `Guerreiro`, `Mago` ou `Arqueiro`. Cada um possui uma forma diferente de atacar. Usamos o padrão Factory Method para criar os personagens dinamicamente com base na escolha do jogador.

### Estrutura do Código

- `IPersonagem`: Interface comum a todos os personagens.
- `Guerreiro`, `Mago`, `Arqueiro`: Implementações concretas de `IPersonagem`.
- `CriadorDePersonagem`: Classe abstrata que define o método `CriarPersonagem()`.
- `CriadorDeGuerreiro`, `CriadorDeMago`, `CriadorDeArqueiro`: Classes concretas que criam os personagens.

### Trecho de código relevante

```csharp
public interface IPersonagem {
    void Atacar();
}

public class Guerreiro : IPersonagem {
    public void Atacar() {
        Console.WriteLine("🗡️ O Guerreiro ataca com sua espada!");
    }
}

public abstract class CriadorDePersonagem {
    public abstract IPersonagem CriarPersonagem();

    public void EntrarNoJogo() {
        var personagem = CriarPersonagem();
        personagem.Atacar();
    }
}

public class CriadorDeGuerreiro : CriadorDePersonagem {
    public override IPersonagem CriarPersonagem() {
        return new Guerreiro();
    }
}
```

---

## 🎮 Resultado no Console

Se o jogador escolher "guerreiro":

```
🗡️ O Guerreiro ataca com sua espada!
```

Se escolher "mago":

```
✨ O Mago lança uma bola de fogo!
```

Se escolher "arqueiro":

```
🏹 O Arqueiro dispara uma flecha precisa!
```

---

## 📘 Aprendizado

- O Factory Method ajuda a **desacoplar a lógica de criação** da lógica de uso dos objetos.
- Facilita a **manutenção** e **extensão** do sistema, pois novas classes podem ser adicionadas com pouco impacto.
- Promove o uso de **interfaces e herança** para manter o código flexível e testável.

---

> Esse padrão é ideal para cenários onde as **decisões sobre qual classe instanciar** podem variar de acordo com o contexto, como neste exemplo de escolha de personagens em um jogo.
