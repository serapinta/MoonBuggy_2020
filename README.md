# Moon Buggy

# Autoria

## Autores

Pedro Oliveira - 21705187

Sara Gama - 21705494

## Repartição do Projecto

Pedro Oliveira - O envolvimento foi feito através das classes Buggy, calculateScore, Game, Hole, 
HoleSpawner, Quitter e seus comentários e ainda o uml (em conjunto).

Sara Gama - A participação no projecto é mostrado através das classes Program, Menu e Score
fez comentários das mesmas, fez ainda o fluxugrama, uml (em conjunto), o ficheiro 
READEME e a documentação Doxygen.

## Repositório Remoto
 [MoonBuggy_2020](https://github.com/serapinta/MoonBuggy_2020)

# Arquitectura da solução

## Descrição da solução

O jogo Moon Buggy contem um menu no qual há intruções sobre o jogo, podemos ver a pontuação 
máxima e ainda os creditos. O jogo em si é iniciado apartir da classe Game onde é definido o 
tamanho do mundo os frames da cena e a iniciação da pontuação. A classe Buggy é onde o carro 
é onde a sua sprite é desenhada e onde se determina a interagir com o mundo. O chão é feito 
no Game mas a localização dos picos é feita na classe HoleSpawner onde são aleatóriamente 
colocados no mundo enquanto que a classe Hole desenha os picos.
Durante o jogo se quiser desisitir pode faze-lo na tecla _escape (esc)_ e isto encontra-se
feito na classe Quitter. Highscore é um ficheiro onde é guardado a informação da pontuação
máxima efectuada por parte dos jogadores, já a classe Score cria o ficheiro Highscore.txt
onde se pode ler ou escrever dados sobre a pontuação dos jogadores faz igualmente a 
comparação entre a última pontuação do jogador e as já presentes no ficheiro de forma a 
actualizar as pontuações, finalmente a classe CalculateScore serve para dar a pontuação por 
cada salto efectuado.

## Diagrama UML 

![UML](https://github.com/serapinta/MoonBuggy_2020/blob/master/Imagens/UML_moonBuggy.png)

## Fluxograma
![Fluxugrama](https://github.com/serapinta/MoonBuggy_2020/blob/master/Imagens/Fluxograma_moonBuggy.png)

# Referências

[Slides e aulas fornecidas pelo professor](https://github.com/VideojogosLusofona/lp2_2020_aulas)
