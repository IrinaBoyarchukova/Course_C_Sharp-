// 3.4 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N. 
// 5 -> 1, 4, 9, 16, 25 // 2 -> 1,4
void Searching (int a) 
{    
     int b = 1; 
    while (b <= a)  
   {        
     Console.WriteLine(Math.Pow(b, 2));  
            b = b+1;    
   } 
} 
Searching(10);
