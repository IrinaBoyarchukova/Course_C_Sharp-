//  2.4 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
void Weekend(int num)
{
    string Text="Нет";
    if (num==7 || num==6) Text = "Да";
    
    Console.WriteLine($"{num}->{Text}");
}
Weekend(6);
//Weekend(7);
//Weekend(1);