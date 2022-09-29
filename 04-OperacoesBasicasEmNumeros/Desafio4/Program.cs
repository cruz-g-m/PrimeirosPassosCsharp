/*
Escreva um código que usará uma fórmula para converter uma temperatura de graus Fahrenheit para Celsius.
Você imprimirá o resultado em uma mensagem formatada para o usuário.

Comece com esta linha de código:
int fahrenheit = 94;

Para converter temperaturas de graus Fahrenheit para Celsius, primeiro subtraia 32 e, em seguida,
multiplique por cinco nonos (5/9).

Por fim, você combinará as variáveis com cadeias de caracteres literais passadas para uma série de comandos Console.WriteLine() para formar a mensagem completa.

Quando você tiver terminado, a mensagem deverá ser semelhante à seguinte saída:

The temperature is 34.444444444444444444444444447 Celsius.
*/

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);

Console.WriteLine($"The temperature is {celsius} Celsius.");