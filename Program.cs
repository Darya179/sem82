//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Sum(int[,] sArray, int m, int n)
{
    
    int Sum_min = 0;    
    int Sum = 0;    
    int min = 0;
    
    for (int j = 0; j < n; j++)
    { 
        Sum_min = Sum_min + sArray[0,j];
    }

    for (int i = 0; i < m; i++)
    {   
       
        for (int j = 0; j < n; j++)
        
            Sum = Sum + sArray[i,j];

            if (Sum_min > Sum)
            {
                Sum_min = Sum;
                min = i;
            }  
            Sum = 0;

    } 
    Console.WriteLine("Наименьшая сумма по строкам: " + Sum_min);
    Console.WriteLine("номер строки: " + min);     
}

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine(" ");
Sum(array, rows,columns);
//PrintArray(array);