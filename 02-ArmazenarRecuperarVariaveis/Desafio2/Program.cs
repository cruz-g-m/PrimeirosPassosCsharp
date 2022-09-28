/*Armazene os seguintes valores da saída em variáveis:
Bob
3
34.4
Essas variáveis devem receber nomes que reflitam sua finalidade.

Selecione o tipo de dados correto para cada uma das variáveis com base no tipo de dados que ela manterá.

Por fim, você combinará as variáveis com cadeias de caracteres literais passadas para uma 
série de comandos Console.Write() para formar a mensagem completa:
"Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius." */

string name = "Bob";
int message = 3;
decimal celsius = 34.4m;

Console.WriteLine("");

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(message);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(celsius);
Console.WriteLine(" celsius.");

Console.WriteLine("");