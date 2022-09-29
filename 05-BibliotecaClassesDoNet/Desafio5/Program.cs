/*
Use um método da classe System.Math para determinar qual dos dois números é maior.
Use o seguinte código como o ponto de partida do seu código:

int firstValue = 500;
int secondValue = 600;
int largerValue;

Console.WriteLine(largerValue);

Seu trabalho é pesquisar e preencher a linha de código ausente que chama um método
da classe Math que aceitará dois valores e retornará o maior deles na variável 
largerValue, que será impressa no console.

Quando você executar seu código, deverá receber a seguinte saída:
600
*/

Console.WriteLine("");

int firstValue = 500;
int secondValue = 600;
int largerValue = System.Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);

Console.WriteLine("");