/* 
+ é o operador de adição
- é o operador de subtração
* é o operador de multiplicação
/ é o operador de divisão 
*/
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("");

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

Console.WriteLine("");

/*Para ver a divisão funcionando corretamente, precisamos usar um tipo de dados 
que dê suporte a dígitos fracionários após o ponto decimal, como decimal. */
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine("Decimal quotient: " + decimalQuotient);

Console.WriteLine("");

/*Para converter int para decimal, você adiciona o operador de conversão antes 
do valor. Você pode usar o nome do tipo de dados entre parênteses na frente do valor para convertê-lo*/
int first = 7;
int second = 5;
decimal quotient2 = (decimal)first / (decimal)second;
Console.WriteLine(quotient2);

Console.WriteLine("");

/*O operador de resto % informa o resto da divisão int. O que você realmente aprende com esse operador 
é se um número é divisível por outro.*/
Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
Console.WriteLine("Modulus of 7 / 5 : " + (7 % 5));

Console.WriteLine("");

/*
Ordem de Operações:
-1-Parêntese (o que estiver dentro do parêntese é executado primeiro)
-2-Exponentes
-3-Multiplicação e Divisão (da esquerda para a direita)
-4-Adição e Subtração (da esquerda para a direita)
*/
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

Console.WriteLine("");