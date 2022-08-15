// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void Print (int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for(int i=0; i<row_size; i++)
    {
        for(int j=0; j<column_size; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Print2(int row, int column, int min, int max)
{
    int[,] arr = new int[row,column];
    
    for(int i=0; i<row; i++)
    {
        for(int j=0; j<column; j++)
        {
            arr[i,j]=new Random().Next(min,max+1);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return(arr);
}

double[] Print3(int[,] arr)
{
    double[] Sum1 = new double[arr.GetLength(0)];
    
    for(int i=0; i<arr.GetLength(0); i++)
    {
        double Sum=0;
        for(int j=0; j<arr.GetLength(1); j++)
        {
            Sum+=arr[i,j];
        }
        Sum1[i]=Sum/arr.GetLength(1);
        Console.Write($"{Sum1[i]} ");
    }
    Console.WriteLine();
    return(Sum1);
}



int[,] arr1 = Print2(4,4,1,10);
Print(arr1);
Print3(arr1);