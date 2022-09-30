/*
Anteriormente, decidimos escrever código para armazenar IDs de pedidos possivelmente 
fraudulentos. Esperamos encontrar pedidos fraudulentos o quanto antes e sinalizá-los 
para uma análise mais profunda.

Nossa equipe detectou um padrão. Pedidos que começam com a letra "B" têm um número de 
fraudes 25 vezes maior que o normal. Vamos escrever um novo código para gerar a ID de 
novos pedidos, em que a ID do pedido começa com a letra "B". Isso será usado por nossa
equipe de fraudes para investigar ainda mais.

Declarar e inicializar uma nova matriz para conter IDs de pedidos falsas.

B123
C234
A345
C15
B177
G3003
C235
B179

Use uma instrução foreach para iterar em cada elemento da matriz que você acabou 
de declarar e inicializar.

Se a ID de Pedido falsa começar com "B", imprima-a na saída.
Avalie cada elemento da matriz. Identifique e imprima para gerar as IDs de pedidos 
possivelmente fraudulentas procurando os pedidos que começam com a letra "B". A 
saída deve corresponder ao seguinte:

B123
B177
B179

Para determinar se um elemento começa ou não com a letra "B", use o método String.StartsWith().

*/

Console.WriteLine("");

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}

Console.WriteLine("");