// 2.3 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5 ; 78 -> третьей цифры нет; 32679 -> 6
Console.WriteLine("Введите  число");
void ThirdNum (int num)
{
    Console.Write($"{num} -> ");
    if (num < 99)
    { 
     Console.WriteLine("Нет третьего числа");
     return;   
    }
    while (num > 999) num= num/10;
    Console.WriteLine(num % 10);
}
ThirdNum(int.Parse (Console.ReadLine()));