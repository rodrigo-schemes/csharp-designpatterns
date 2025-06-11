# 🏗️ Abstract Factory Pattern — Exemplo: TeamFactory

Este projeto em C# demonstra o uso do padrão de projeto **Abstract Factory**, utilizando como exemplo a criação de times esportivos com diferentes formações e posições de acordo com o esporte selecionado (futebol, basquete, vôlei etc).

---

## 📘 Definição (GoF)

> **Abstract Factory** é um padrão criacional que fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.

---

## 🧠 Quando usar?

Você deve considerar o uso do Abstract Factory quando:

- O sistema precisa ser independente da forma como seus objetos são criados e representados;
- Os objetos criados devem ser utilizados em conjunto (família de objetos);
- Você deseja garantir a consistência entre os objetos relacionados;
- O código precisa ser extensível para novas famílias de produtos (ex: novos esportes, novos estilos de times, etc).

---

## 🎮 Exemplo: Criador de Times

Neste projeto, simulamos a criação de **times completos** com base em diferentes esportes:

- ⚽ Futebol: goleiro, zagueiros, laterais, meias, atacantes
- 🏀 Basquete: armador, alas, pivôs
- 🏐 Vôlei: levantadora, centrais, ponteiras, oposta, líbero

### 🏗️ Componentes principais:

- `ITeamFactory` — a **Abstract Factory**, define os métodos para criar jogadores por posição e técnico.
- `SoccerTeamFactory`, `BasketballTeamFactory`, `VolleyballTeamFactory` — **Factories concretas** que criam jogadores específicos para cada esporte.
- `Goleiro` e `Atacante` — classes de produto com informações como nome e posição.
- `TeamManager` — classe cliente que usa a factory para construir e exibir o time completo.

### 🎯 Resultado Esperado

Após escolher um dos esportes disponíveis e executar o programa, você verá no console a composição completa do time, exibindo:

- Nome do time (ex: "Palmeiras 2025")
- Lista de jogadores com nome e posição

Cada factory retorna um conjunto coeso de jogadores adequados ao esporte selecionado.

---

## 💡 Aprendizados

Este exemplo reforça os seguintes conceitos:

- **Desacoplamento** entre o código cliente e as classes concretas;
- **Organização orientada a famílias de objetos relacionados**;
- **Facilidade de extensão**: basta criar uma nova factory concreta para suportar outro esporte;
- Ajuda a manter a coesão e encapsula a lógica de construção em um local único.