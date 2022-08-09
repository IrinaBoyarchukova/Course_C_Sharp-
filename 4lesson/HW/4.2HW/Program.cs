// 2. Напишите программу, которая принимает  на вход число и выдаёт сумму цифр в числе.
// https://shwanoff.ru/char-c-sharp/


double DigitSum(int num)
{
    string n = num.ToString();
    int length = n.Length;
    double sum = 0;
    
    for (int i = 0; i < length; i++)
    {   
        double m = char.GetNumericValue(n[i]);        
        sum += m;
    }

    return sum;
}

int n = 123;

Console.WriteLine(DigitSum(n));