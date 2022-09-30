/*
O aninhamento nos permite colocar blocos de código dentro de blocos de 
código. Neste caso, vamos aninhar instruções if e else (a verificação de 
resultados triplicados) dentro de outra instrução if (a verificação de 
resultados duplicados) para impedir que ambos aconteçam.

Aninharemos a verificação de resultados triplicados dentro da verificação 
de duplicados. Modifique o código de forma que corresponda à seguinte listagem de código:
*/

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

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

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

/*
Para tornar o jogo mais divertido, em vez de vencer/perder, vamos conceder 
prêmios fictícios para cada pontuação. Ofereceremos quatro prêmios. O jogador 
deve ganhar apenas um prêmio:

Se a pontuação do jogador for maior ou igual a 16, ele ganhará um carro novo.
Se a pontuação do jogador for maior ou igual a 10, ele ganhará um laptop novo.
Se a pontuação do jogador for exatamente 7, ele ganhará uma viagem.
Caso contrário, ganhará um gatinho.

*/