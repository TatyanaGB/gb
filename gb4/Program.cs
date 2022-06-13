//Задача 4
Console.WriteLine("Введите число a: ");
int a = ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b:  ");
int b = ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c:  ");
int c = ToInt32(Console.ReadLine());

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("max=  ");