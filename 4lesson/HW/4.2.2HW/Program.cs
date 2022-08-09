// 2. Напишите программу, которая принимает
//    на вход число и выдаёт сумму цифр в числе.


int SumNums(int num)
{
    int n_sum = 0;

    while (num > 0)
    {
        n_sum += num % 10;
        num /= 10;
    }
    return n_sum;
}


// --------------------------------- 2 вариант

//int SumNums(int num)
//{
//    int n_sum = 0;

 //   for (int i = num; num != 0; num /= 10)
  //      n_sum += num % 10;

   // return n_sum;
//}

Console.WriteLine(SumNums(452));
Console.WriteLine(SumNums(82));
Console.WriteLine(SumNums(9012));