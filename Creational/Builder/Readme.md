
# 🍔 Builder Design Pattern - Exemplo com Step Builder

Este projeto demonstra o uso do padrão de projeto **Builder**, utilizando a variação **Step Builder**, para construção de objetos complexos com etapas obrigatórias e opcionais — no contexto de uma **lanchonete** que monta lanches como X-Salada, X-Burger e HotDog.

---

## 🔍 Definição

**Builder** é um padrão de projeto criacional que permite criar objetos complexos passo a passo, isolando a lógica de construção da lógica de representação. Ele é útil quando um objeto pode ter muitas combinações de parâmetros ou exige uma ordem de construção.

> **Problema resolvido:** construção de objetos com muitos parâmetros opcionais, garantindo legibilidade e consistência.

---

## 🔢 Tipos de Builder (com comparação)

| Tipo            | Característica principal                                         | Exemplo de uso comum                | Vantagens                                   |
|------------------|------------------------------------------------------------------|-------------------------------------|---------------------------------------------|
| Classic Builder  | Usa uma classe separada com métodos `SetX` e `Build`            | Java GoF padrão                     | Separação clara entre criação e objeto      |
| Fluent Builder   | Encadeia métodos com `return this`                              | APIs legíveis e concisas            | Código elegante, legível e compacto         |
| Nested Builder   | Usa classes internas para construção de partes (composições)    | Objetos com subcomponentes          | Modularidade para objetos compostos         |
| Step Builder     | Enforceia ordem de chamada entre métodos                        | Fluxos obrigatórios (como cadastro) | Segurança de construção e guia de uso       |
| Inner Builder    | Builder embutido dentro da própria classe                       | Configurações simples               | Conveniência e encapsulamento               |

---

## 🧭 Quando usar o Builder?

Use o padrão Builder quando:

- O objeto tem **muitos parâmetros opcionais** ou com **ordem obrigatória**.
- Deseja **evitar construtores longos** e difíceis de entender.
- Precisa de **legibilidade** e **imposição de regras** na construção.
- Quer permitir **variações claras** de montagem de um mesmo tipo.

---

## 🍟 Nosso contexto: Lanchonete com Step Builder

Neste projeto, simulamos uma lanchonete onde os lanches são montados obrigatoriamente seguindo os passos:

1. Escolher o **tipo de pão**
2. Escolher o **tipo de carne**
3. Adicionar **opcionais** (como queijo, alface, ketchup etc.)
4. Finalizar com `Build()`

A estrutura usa o padrão **Step Builder** para garantir essa sequência obrigatória e evitar erros de uso na construção do lanche.

```csharp
var xSalada = LancheBuilder
    .Criar()
    .ComPao("Pão de hambúrguer")
    .ComCarne("Carne bovina")
    .ComAdicionais("Alface", "Tomate", "Queijo")
    .Build();
```

---
## 📂 Estrutura

```
├── Builder/
│   ├── Lanche.cs
│   ├── LancheBuilder.cs
│   └── Steps/
│       ├── IPaoStep.cs
│       ├── ICarneStep.cs
│       ├── IAdicionalStep.cs
│       └── ILancheFinalStep.cs
├── Program.cs
├── README.md
```

---

## 🎯 Resultado

- Lanches X-Salada, X-Burger e HotDog são montados com validação de etapas.
- Um menu de console permite ao usuário escolher o lanche e ver o resultado final.
- A lógica de construção está **fortemente tipada** e **segura em tempo de compilação**.

### Menu no Console:

```
🍔 Bem-vindo à Lanchonete!
Escolha o lanche:
1 - X-Salada
2 - X-Burger
3 - HotDog
Sua escolha: 1

✅ Lanche montado: Lanche com Pão de hambúrguer, Carne bovina, adicionais: Alface, Tomate, Queijo
```

---

## 📘 Aprendizado

- O padrão **Step Builder** é útil para forçar **ordens válidas** na criação de objetos.
- A **legibilidade e segurança** do código aumentam, apesar do número maior de interfaces.
- Ideal para cenários como: **formulários, montagem de pedidos, fluxos guiados**, etc.

---