//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Write number: ");
int a = int.Parse(Console.ReadLine());
if (a%2==0)
    Console.WriteLine("Число четное и делится  на два без остатка");
else
    Console.WriteLine("Число нечетное");
