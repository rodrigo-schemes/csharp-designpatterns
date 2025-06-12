
# Evolução de Personagem com Prototype (C#)

## 🧠 Definição
Este projeto demonstra o uso do padrão de projeto **Prototype** com **Deep Copy** em C#. Ele simula a evolução de um personagem ao longo dos períodos históricos, clonando e modificando versões anteriores do personagem para refletir novas eras, armas, armaduras e poder de ataque.

---

## 🔍 Tipo de Prototype
- **Deep Copy (Cópia Profunda)**: Cada clone é completamente independente do original, incluindo objetos aninhados (`Equipamento` neste caso).

---

## 🧾 Diferença entre Shallow Copy e Deep Copy

| Característica              | **Shallow Copy**                                          | **Deep Copy**                                              |
|----------------------------|------------------------------------------------------------|-------------------------------------------------------------|
| **Referência de Objetos**  | Copia apenas as referências dos objetos aninhados         | Cria novas instâncias para todos os objetos aninhados       |
| **Independência**          | As alterações nos objetos internos afetam o original      | Os objetos são completamente independentes                  |
| **Performance**            | Mais rápida e leve, pois não copia estruturas complexas   | Mais lenta, pois copia tudo profundamente                   |
| **Uso típico**             | Quando os objetos são imutáveis ou compartilhamento é intencional | Quando é necessário total isolamento entre os clones         |
| **Exemplo em C#**          | `MemberwiseClone()` (sem sobrescrita)                     | Implementação manual de `ICloneable` com `.Clone()` profundo |

---

## 🕵️‍♂️ Quando Usar
Use o padrão Prototype quando:
- É necessário criar cópias de objetos complexos.
- Deseja evitar os custos de criação de instâncias com estados similares.
- Precisa garantir que alterações em cópias não afetem o original (deep copy).

---

## 🌍 Contexto
Neste exemplo lúdico, um personagem começa na **Pré-História** e evolui pelas eras:
- Idade Antiga
- Idade Média
- Idade Moderna
- Idade Contemporânea

A cada era:
- A arma e a armadura são atualizadas.
- O **poder de ataque** é multiplicado por 2.
- O personagem é **clonado** e **personalizado**, mantendo os dados do passado intactos.

---

## 🎯 Resultado

Cada instância representa uma versão histórica distinta do mesmo herói. Exemplo:

```
Herói - Era: Idade Contemporânea
  Arma: Rifle de Precisão
  Armadura: Colete Tático
  Poder de Ataque: 16
```

---

## 📚 Aprendizado

Este exemplo permite compreender:
- A importância de deep copy em cenários com composição.
- Como aplicar Prototype para criar variações de um objeto.
- Diferenças entre Shallow Clone e Deep Clone
