int value = 0;
value = value + 5;
value += 5;

int value2 = 0;
value2 = value2 +1;
value2++;

//int value3 = 1;

Console.WriteLine("");

int value4 = 1;

value4 = value4 + 1;
Console.WriteLine("First increment: " + value4);

Console.WriteLine("");

value4 += 1;
Console.WriteLine("Second increment: " + value4);

Console.WriteLine("");

value4++;
Console.WriteLine("Third increment: " + value4);

Console.WriteLine("");

value4 = value4 - 1;
Console.WriteLine("First decrement: " + value4);

Console.WriteLine("");

value4 -= 1;
Console.WriteLine("First decrement: " + value4);

Console.WriteLine("");

value4--;
Console.WriteLine("Third decrement: " + value4);

Console.WriteLine("");

int value5 = 1;
value5++;
Console.WriteLine("First: " + value5);
Console.WriteLine("Second: " + value5++);
Console.WriteLine("Third: " + value5);
Console.WriteLine("Fourth: " + (++value5));

Console.WriteLine("");