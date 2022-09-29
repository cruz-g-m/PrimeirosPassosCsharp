/*
Como chamar métodos na Biblioteca de Classes do .NET
Com base em sua experiência anterior com o método Console.WriteLine(), você já deve conhecer os conceitos básicos:

Comece digitando o nome de classe, Console
Adicione o operador de acesso de membro, o símbolo .
Adicione o nome do método, WriteLine
Adicione o operador de chamada do método, que é um conjunto de parênteses ()
Por fim, adicione o valor que você deseja que o método Console.WriteLine() imprima como um parâmetro de entrada 
entre os parênteses de abertura e fechamento (por exemplo, "Hello World!")

Opcionalmente, dependendo de como os desenvolvedores criaram e implementaram o método especificado, você também precisará:

Passar valores adicionais como parâmetros de entrada
Aceitar um valor retornado

O seguinte exemplo simula uma jogada de dados gerando um número aleatório e imprimindo-o no console:
*/
Console.WriteLine("");

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

Console.WriteLine("");
/*
A primeira linha de código cria uma instância da classe System.Random na Biblioteca de Classes do .NET e armazena a 
referência ao novo objeto em uma variável denominada dice.

A segunda linha de código chama o método Next() do objeto dice que passa dois parâmetros: o valor mínimo e o máximo 
do número aleatório. O método Next() retorna o valor, que salvamos em uma variável chamada roll.

A terceira linha de código chama o método WriteLine() para imprimir o valor de roll no console.

Neste exemplo de código, estamos chamando um método da classe Random e da classe Console. No entanto, a maneira 
como estamos chamando esses métodos é diferente. O motivo pelo qual eles foram chamados usando uma técnica 
diferente é porque alguns métodos são com estado e outros, sem estado.
*/


//===============================================//========================================================//======


/*
Uma instância de uma classe é chamada de um objeto. Para criar uma instância de uma classe, use o operador new. 
Considere a seguinte linha de código que cria uma instância da classe Random para criar um objeto chamado dice:
*/
Random dice2 = new Random();
/*
O operador new faz várias coisas importantes:

Primeiro, ele solicita um endereço na memória do computador grande o suficiente para armazenar um novo objeto 
com base na classe Random.
Ele cria o objeto e o armazena em um endereço de memória.
Ele retorna o endereço de memória para que ele possa ser salvo na variável dice.
*/