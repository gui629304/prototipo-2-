# Protótipo 2

**Aluno:** Guilherme Honorato dos Santos Nunes  
**Turma:** [programação de jogos digitais)  
**Feito com:** Unity 6 e C#

## Sobre o projeto

O Protótipo 2 é um jogo desenvolvido na Unity em que o jogador deve alimentar animais lançando comida. O objetivo é acertar os animais que se aproximam antes que eles consigam atravessar a área de jogo. O projeto foi criado para praticar movimentação, geração de objetos, colisões e programação em C#. Durante o desenvolvimento foram utilizados prefabs, scripts e recursos de física da Unity.

## O que o projeto faz

- O jogador se movimenta horizontalmente pelo cenário.
- O jogador lança alimentos para os animais.
- Animais aparecem automaticamente em posições aleatórias.
- Os animais e os alimentos são destruídos ao colidirem.
- Objetos fora da área de jogo são removidos automaticamente.

## O que o projeto contém

- **Cenas:** Prototype 2
- **Scripts:**
  - `PlayerController.cs` – controla a movimentação do jogador e o lançamento de alimentos.
  - `SpawnManager.cs` – gera animais em intervalos de tempo.
  - `DestroyOutOfBounds.cs` – remove objetos que saem dos limites da área de jogo.
- **Objetos principais:**
  - Player
  - Animal Prefabs
  - Food Prefab
  - Spawn Manager
  - Background
- **Recursos usados:**
  - Rigidbody
  - Collider
  - Prefabs
  - Instantiate()
  - Destroy()
  - Física da Unity

## Controles

- **A / D** ou **← / →** – mover o jogador para os lados
- **Barra de Espaço** – lançar alimento

## O que eu aprendi

Neste projeto aprendi a utilizar prefabs para criar objetos dinamicamente durante a execução do jogo. Também pratiquei o controle de movimentação do jogador, o gerenciamento de colisões e a destruição de objetos por meio de scripts em C#. Além disso, entendi melhor como organizar objetos e componentes dentro da Unity.

## Como abrir

Baixe o projeto, abra o Unity Hub, clique em **Add** e escolha a pasta do projeto.
