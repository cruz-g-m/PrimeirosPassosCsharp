/*
A instrução de ramificação usada mais amplamente é a instrução if. A 
instrução if usa uma expressão booliana colocada entre parênteses. 
Se a expressão for verdadeira, o código após a instrução if será executado. 
Se a expressão for falsa, o código após a instrução if será ignorado.

Usaremos o método Random.Next() para simular a rolagem de três dados de 
seis lados cada. Avaliaremos os valores para calcular a pontuação. Se a 
pontuação for superior a um total arbitrário, exibiremos uma mensagem de 
vitória para o usuário. Caso contrário, exibiremos uma mensagem de derrota 
para o usuário.

**Se quaisquer dois dados rolados resultarem no mesmo valor, você receberá 
dois pontos de bônus pelo resultado duplicado.
**Se os três dados rolados resultarem no mesmo valor, você receberá seis 
pontos de bônus pelo resultado triplicado.
**Se a soma dos três dados rolados, mais quaisquer pontos de bônus, for 
igual ou maior que 15, você vencerá o jogo. Caso contrário, você perderá.

*/

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

/*
Criamos uma nova instância da classe System.Random e armazenamos a 
referência a esse objeto na variável dice. Em seguida, chamamos o método 
Random.Next() no objeto dice três vezes, fornecendo os limites inferior 
e superior para restringir os valores possíveis ao intervalo entre 1 e 6. 
Salvamos os três números aleatórios nas variáveis roll1, roll2 e roll3, 
respectivamente.

Depois, somamos os valores referentes às três vezes em que os dados 
foram rolados e salvamos o resultado na variável total.

Por fim, exibimos todos os valores usando a interpolação de cadeias 
de caracteres.

*/

if (total > 14)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

/*
Adicionamos duas instruções if para lidar com os cenários de vitória e 
derrota. Vamos nos concentrar na primeira instrução if.

A instrução if é composta por três partes:

A palavra-chave if.
Uma expressão booliana entre parênteses ().
Um bloco de código definido por chaves { }.
Em runtime, a expressão booliana total > 14 é avaliada. Se a instrução for 
verdadeira e o valor de total for maior que 14, o fluxo da execução continuará 
para o código definido no bloco de código. Em outras palavras, ele executará 
o código entre as chaves.

No entanto, se a expressão booliana for falsa, o fluxo da execução ignorará o 
bloco de código. Em outras palavras, ele não executará o código entre chaves.

Por fim, a segunda instrução if controla a mensagem caso o usuário perca. Na 
próxima unidade, usaremos uma variação na instrução if para encurtar essas 
duas instruções em uma única instrução e expressar nossa intenção mais claramente.
*/