// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNums (int M, int N)
{
    if (N < M) return 0;
    return SumNums(M, N - 1) + N;
}

Console.WriteLine (SumNums(1, 15)); 
Console.WriteLine (SumNums(4, 8));