Console.WriteLine("");
/*Uma expressão de interpolação é uma variável cercada por um símbolo de chave de abertura e fechamento { }.
A cadeia de caracteres literal se torna um modelo quando ele é prefixado pelo caractere $. */
string firstName = "bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

Console.WriteLine("");
//Você pode executar várias operações de interpolação na mesma linha de código.
string secondName = "Steve";
string greeting = "Hello";
string message2 = $"{greeting} {secondName} !";
Console.WriteLine(message2);

Console.WriteLine("");

string thirdName = "Gui";
string greeting2 = "Helo";
Console.WriteLine($"{greeting2} {thirdName}");

Console.WriteLine("");
//Você pode usar o símbolo @ de prefixo literal textual e o símbolo $ de interpolação de cadeia de caracteres juntos.
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");


