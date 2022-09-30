/*
vamos implementar uma nova regra: "Se quaisquer dois dados rolados resultarem 
no mesmo valor, você receberá dois pontos de bônus pelo resultado duplicado". 

Em seguida, vamos adicionar uma nova regra: "se todos os três dados que você 
jogar resultarem no mesmo valor, você obterá seis pontos de bônus".

*/

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

/*
Aqui, combinamos duas expressões boolianas para criar uma expressão booliana 
composta em uma só linha de código. Temos um conjunto de parênteses externo 
que combina dois conjuntos de parênteses internos separados por dois 
caracteres de E comercial.

Dois caracteres de E comercial duplos && são o operador lógico AND, que 
basicamente afirma que "somente se duas as expressões forem verdadeira, a 
expressão inteira será verdadeira". Nesse caso, se roll1 for igual a roll2, e 
roll2 for igual a roll3, roll1 deverá ser igual a roll3 e o usuário teve 
um resultado triplicado.
*/