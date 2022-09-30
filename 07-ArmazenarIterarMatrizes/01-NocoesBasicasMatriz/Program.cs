/*
Uma matriz é uma sequência de elementos de dados individuais que pode ser 
acessada por meio de um único nome de variável. Use um índice numérico 
baseado em zero para acessar cada elemento de uma matriz. Como você verá, as 
matrizes permitem coletar dados semelhantes com uma finalidade ou 
características em comum em uma única estrutura de dados para facilitar o 
processamento.

Declarar matrizes
Uma matriz é um tipo especial de variável que pode conter vários valores 
do mesmo tipo de dados. A sintaxe da declaração é ligeiramente diferente 
porque é necessário especificar o tipo de dados e o tamanho da matriz.

*/

string[] fraudulentOrderIDs = new string[3];

/*
O operador new cria uma instância de uma matriz na memória do computador 
que pode conter três valores de cadeia de caracteres. Para saber mais sobre 
a palavra-chave new, confira o módulo "Chamar métodos da Biblioteca de 
Classes .NET usando C#".

Observe que o primeiro conjunto de colchetes [] simplesmente indica ao 
compilador que a variável de nome fraudulentOrderIDs será uma matriz. No 
entanto, o segundo conjunto de colchetes [3] contém o número de elementos 
que a matriz conterá.
*/

/*
Já declaramos uma matriz de cadeias de caracteres, mas todos os elementos 
dela estão vazios. Para acessar um elemento de uma matriz, use um índice 
numérico baseado em zero dentro de colchetes.

Atribua um valor usando o valor de atribuição = como se fosse uma variável 
normal.

*/

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

/*
Use o mesmo processo para obter o valor de um elemento em uma matriz. 
Use o índice do elemento para recuperar seu valor.
*/

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

/*
Reatribuir o valor de uma matriz
Os elementos de uma matriz são como qualquer outro valor de variável, 
de modo que você pode atribuir, recuperar e reatribuir um valor a cada 
elemento da matriz.
*/

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");


/*
Inicializar uma matriz
Assim como você pode inicializar uma variável no momento em que a declara, 
é possível inicializar uma nova matriz no momento da declaração usando 
uma sintaxe especial, incluindo chaves.
*/

string[] fraudulentOrderIDs2 = { "A123", "B456", "C789" };

/*
Dependendo de como a matriz é criada, talvez você não saiba com antecedência 
quantos elementos ela contém. Para determinar o tamanho de uma matriz, você 
pode usar a propriedade Length.
*/

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
