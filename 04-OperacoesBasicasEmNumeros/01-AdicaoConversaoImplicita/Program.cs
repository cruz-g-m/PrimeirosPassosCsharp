Console.WriteLine("");
//Para adicionar dois números, usaremos o operador de adição, que é o símbolo de mais +. 
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

Console.WriteLine("");
//Neste caso, o compilador de C# entende que queremos usar o símbolo + para concatenar os dois operandos.
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

Console.WriteLine("");
/*Em vez de adicionar a variável intwidgetsSold ao literal int7, o compilador trata tudo como uma cadeia 
de caracteres e concatena tudo.*/
string secondName = "Steve";
int widgetsSold2 = 7;
Console.WriteLine(secondName + " sold " + widgetsSold2 + 7 + " widgets");

Console.WriteLine("");
/*O símbolo de parênteses () se torna outro operador sobrecarregado. Neste caso, os parênteses de 
abertura e fechamento formam o operador de ordem de operações, exatamente como você usaria em uma fórmula matemática.*/
string thirdName = "Gui";
int widgetsSold3 = 7;
Console.WriteLine(thirdName + " sold " + (widgetsSold3 + 7) + " widgets");

Console.WriteLine("");