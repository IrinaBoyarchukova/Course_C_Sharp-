﻿// 3. Напишите программу, которая принимает на вход число (N)
//    и выдаёт таблицу кубов чисел от 1 до N.


void Squares(int n)
{
    double[] nums = new double[n];
    int index = 0;

    Console.Write($"{n} -> ");

    while (index < n)
    {
        nums[index] = Math.Pow((index + 1), 3);
        Console.Write($"{nums[index]}, ");
        index += 1;
    }    
    Console.WriteLine();
}

Squares(6);
Squares(2);
Squares(11);