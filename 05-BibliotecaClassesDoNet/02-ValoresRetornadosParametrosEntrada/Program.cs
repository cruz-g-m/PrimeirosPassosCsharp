/*
Métodos criados para retornar um valor após a conclusão normalmente são o resultado de uma 
operação. Um valor retornado é a principal maneira como um método pode se comunicar de volta 
com o código que chama o método.

Um método pode ser criado para retornar qualquer tipo de dados, até mesmo outra classe.
Nesse caso, o método Random.Next() retorna um valor int do número gerado aleatoriamente. 
Salvamos o valor retornado em uma variável para uso posterior em nosso código. Poderíamos
ter ignorado o valor retornado da seguinte forma:

dice.Next(1, 7);

No entanto, isso seria inútil. O motivo pelo qual estamos chamando este método é para que 
possamos recuperar o próximo valor aleatório do objeto Random.
*/

/*
Na seguinte linha de código, os dois parâmetros de entrada definem os limites inferior e 
superior, respectivamente, para o método Next(), conforme ele gera um novo número aleatório:
*/
Console.WriteLine("");

Random dice = new Random();
int roll = dice.Next(1, 7);

/*
E na seguinte linha de código, são nos parâmetros de entrada que WriteLine() opera para ser 
exibido no console:
*/
Console.WriteLine(roll);

Console.WriteLine("");

//==========================================//==============================================

/*
Métodos sobrecarregados
Muitos métodos na Biblioteca de Classes do .NET têm assinaturas de método sobrecarregado.

Um método sobrecarregado é definido com várias assinaturas de método. Os métodos 
sobrecarregados oferecem diferentes maneiras de chamar o método ou diferentes tipos de dados.

Em alguns casos, versões sobrecarregadas de um determinado método permitem enviar 
valores de tipos de dados diferentes para o método. Por exemplo, o método Console.WriteLine() 
tem 19 versões sobrecarregadas diferentes. A maioria dessas sobrecargas permite enviar 
diferentes tipos de dados para imprimir no console.
*/

int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

Console.WriteLine("");
/*
Neste exemplo, você invocará três versões sobrecarregadas separadas do método WriteLine().
*/

/*
Em outros casos, as versões sobrecarregadas de um determinado método permitem enviar 
detalhes de configuração adicionais para o método sobre o resultado desejado. Por exemplo, 
o método Random.Next() tem três versões sobrecarregadas diferentes. As três versões 
permitem definir restrições sobre o número gerado aleatoriamente.
*/
Random dice1 = new Random();
int roll1 = dice1.Next();
int roll2 = dice1.Next(101);
int roll3 = dice1.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

Console.WriteLine("");

/*
A primeira versão do método Next() não define um limite superior e inferior; portanto, 
o método retornará valores que variam de 0 a 2,147,483,647, que é o valor máximo 
que um int pode armazenar.

A segunda versão do método Next() especifica o valor máximo como um limite superior. 
Portanto, nesse caso, podemos esperar um valor aleatório entre 0 e 100.

A terceira versão do método Next() especifica os valores mínimo e máximo. Portanto, 
nesse caso, podemos esperar um valor aleatório entre 50 e 100.
*/

//========================================//============================================

/*
Usar o IntelliSense
Primeiro, o IntelliSense do editor de código pode informar muito sobre um método 
sem sair do ambiente de codificação. O IntelliSense é um recurso de editores de código 
da Microsoft. Ele fornece dicas e informações de referência breves em uma janela 
pop-up sob seu cursor enquanto você insere o código.


Usar docs.microsoft.com para obter informações sobre métodos sobrecarregados
A segunda maneira de saber mais sobre versões sobrecarregadas dos métodos é consultando
a documentação do método. A documentação também ajudará a entender exatamente a que se 
destina cada parâmetro de entrada.
*/

