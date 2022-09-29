Console.WriteLine("");
//O código a seguir usa sequências de caracteres de escape para adicionar espaço em branco.
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

Console.WriteLine("");

//E se você precisar inserir uma aspa dupla em uma cadeia de caracteres literal, use a sequência de escape \".
Console.WriteLine("Hello \"World\"!");

Console.WriteLine("");

//E se você precisar usar a barra invertida para outras finalidades, use a \\ para exibir uma barra invertida simples.
Console.WriteLine("c\\source\\repos");

Console.WriteLine("");

//Modelo de Ferramenta de linha de comando.
Console.WriteLine("Generating invoices for custumer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

/*use a diretiva @ antes da cadeia de caracteres literal. Dois caracteres de aspas duplas consecutivas ("") são 
impressos como um único caractere de aspas duplas (") na cadeia de caracteres de saída.*/
Console.WriteLine(@"c:\invoices");

Console.WriteLine("");
