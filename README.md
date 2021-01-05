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

O programa foi feito de maneira a que o utilizador tenha acesso somente as informações a 
partir do _MenuDrawer_. A classe _MenuDrawer_ utiliza os métodos das classes _abstract_ 
para fazer o gerenciamento de todas as informações necessárias para que o utilizador tenha 
o mínimo de dificuldade para fazer as pesquisas, sendo necessário utilizar as informações 
passadas em casa menu. Dessa maneira protegemos a informação passada pelo menu das alterações
assim como mantemos o programa simples com todas as funções necessárias.
As coleções utilizadas foram coleções genéricas para melhor gestão de variáveis e para manter
as regras do sistema _SOLID_.
Uma das maneiras que utilizamos como optimização do código foi não utilizar o _loop foreach_
para levar em consideração a grande quantidade de valores que pode ser passada pelo arquivo 
_.csv_ para serem lidos.

O jogo Moon Buggy contem um menu no qual há intruções sobre o jogo, podemos ver a pontuação máxima e ainda os 
creditos. O jogo em si é realizado apartir da classe 

## Diagrama UML 

![UML]()

## Fluxograma
![Fluxugrama](https://github.com/serapinta/MoonBuggy_2020/blob/master/Imagens/Fluxograma_moonBuggy.png)

# Referências

[Slides e aulas fornecidas pelo professor](https://github.com/VideojogosLusofona/lp2_2020_aulas)

