// 3.1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет; 12821 -> да; 23432 -> да
Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Write a number b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Write a number с: ");
int c = int.Parse(Console.ReadLine());
Console.WriteLine("Write a number d: ");
int d = int.Parse(Console.ReadLine());
Console.WriteLine("Write a number e: ");
int e = int.Parse(Console.ReadLine());
if (a == e && b == d)
    Console.WriteLine("Число палиндромом");
else
    Console.WriteLine("Число Не палиндромом");
