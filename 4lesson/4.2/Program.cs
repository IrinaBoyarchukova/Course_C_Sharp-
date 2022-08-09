/// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.

// 1 вариант

//int NumCount(int num)
//{
 //   string result = num.ToString();
 //   return result.Length;
//}

//Console.WriteLine(NumCount(456));
//Console.WriteLine(NumCount(78));
//Console.WriteLine(NumCount(89126));


// 2 вариант

int NumCount(int num)
{
    int result = 0;

    while (num > 0)
    {
        num /= 10;
        result += 1;
    }
    return result;
}

Console.WriteLine(NumCount(456));
Console.WriteLine(NumCount(78));
Console.WriteLine(NumCount(89126));