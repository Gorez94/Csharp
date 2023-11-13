/*53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2*/

/*using System.Reflection.Metadata;

int[,] RandomArray(int sizeline, int sizecolumns, int maxValue, int minValue)
{
    int[,] array = new int[sizeline, sizecolumns];
    for (int i = 0; i < sizeline; i++)
    {
        for (int j = 0; j < sizecolumns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество колон и строк");
int countcolumn = Convert.ToInt32(Console.ReadLine());
int countline = Convert.ToInt32(Console.ReadLine());
int[,] ArrayUser = RandomArray(countline, countcolumn, 10, 0);
PrintArray(ArrayUser);
Console.WriteLine("------------------");
int[,] ChangeLine(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0)-1; i++)
    {
        int time = Array[0, i];
        Array[0, i] = Array[Array.GetLength(0) - 1, i];
        Array[Array.GetLength(0)- 1, i] = time;
        
    }
    return Array;
}
int[,] newArray = ChangeLine(ArrayUser);
PrintArray(newArray);
Console.ReadKey();
*/
Console.Clear();

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
void SwapFirstAndLastRow(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int columns = arr.GetLength(1);

        for (int j = 0; j < columns; j++)
        {
            int tmp = arr[0, j];
            arr[0, j] = arr[rows - 1, j];
            arr[rows - 1, j] = tmp;
        }
    }

int[,] array2D = new int[3, 4];
FillArray(array2D);
Print2DArray(array2D);
SwapFirstAndLastRow(array2D);
System.Console.WriteLine();
Print2DArray(array2D);