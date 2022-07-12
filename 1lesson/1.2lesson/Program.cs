//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго (5 и 25).
Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number b: ");
int b = int.Parse(Console.ReadLine());

if (a * a == b)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");