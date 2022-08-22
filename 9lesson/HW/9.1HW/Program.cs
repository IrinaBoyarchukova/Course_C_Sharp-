//  Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""2, 4""
// M = 4; N = 8. -> ""4, 6, 8""
void NaturNum (int m, int n)
{
    if (n%2 != 0)
        n = n - 1;
    if (n < m) return;
    NaturNum(m, n-2);
    Console.Write ($" {n} ");
}

NaturNum(1,5);
NaturNum(4,8);