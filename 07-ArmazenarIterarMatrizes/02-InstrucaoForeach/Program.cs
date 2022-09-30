/*
A instrução foreach realiza um loop em cada elemento da matriz, executando 
o bloco de código abaixo da declaração e substituindo o valor em uma variável 
temporária pelo valor da matriz representada pelo loop atual.
*/

Console.WriteLine("");

string[] names = { "Bob", "Conrad", "Grant" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("");

/*
Abaixo da palavra-chave foreach, o bloco de código que contém Console.WriteLine(name); 
será executado uma vez para cada elemento da matriz names. Como o runtime do .NET 
executa um loop em cada elemento da matriz, o valor armazenado no elemento atual da 
matriz names será atribuído à variável temporária name para facilitar o acesso 
dentro do bloco de código.
*/

//===============================================//=====================================

/*
Criar uma matriz de int que armazenará o número de produtos finais em cada compartimento.
*/

int[] inventory = { 200, 450, 700, 175, 250 };

/*
Defina uma nova variável que representa a soma de todos os produtos finais no depósito. 
Não se esqueça de adicioná-la fora da instrução foreach.
*/
int sum = 0;

/*
Acima da instrução foreach, declare e inicialize uma nova variável do tipo int para armazenar 
o número atual do compartimento cujo inventário está sendo processado.
*/
int bin = 0;

/*
Em seguida, adicione uma instrução foreach que itera em cada elemento da matriz inventory, 
atribuindo temporariamente o valor do elemento atual à variável items. Seu código deve 
corresponder à listagem a seguir.

Dentro da instrução foreach, adicione a linha de código, que acrescenta o valor 
atual armazenado em items à variável sum.

Dentro do bloco de código foreach, incremente o compartimento cada vez que o bloco de 
código for executado.

Por fim, dentro do foreach, exiba o compartimento, a contagem de produtos finais e o 
total atual de produtos finais em uma mensagem bem formatada.
*/

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");

Console.WriteLine("");