﻿//  2.3 Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.

//    34, 5 -> не кратно, остаток 4
//    16, 4 -> кратно

Console.WriteLine("Выводит сообщение:");
void Method1(int a, int b)
{
    if (a%b==0)
    Console.WriteLine("кратко");
    else
    {
        Console.WriteLine($"не кратко {a%b}");
            }
}
Method1(34,5);
