/*
O aninhamento nos permite colocar blocos de código dentro de blocos de 
código. Neste caso, vamos aninhar instruções if e else (a verificação de 
resultados triplicados) dentro de outra instrução if (a verificação de 
resultados duplicados) para impedir que ambos aconteçam.

Aninharemos a verificação de resultados triplicados dentro da verificação 
de duplicados. Modifique o código de forma que corresponda à seguinte listagem de código:
*/

int roll1 = 6;
int roll2 = 6;
int roll3 = 6;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}
else 
{
    Console.WriteLine("Sorry, you lose.");
}