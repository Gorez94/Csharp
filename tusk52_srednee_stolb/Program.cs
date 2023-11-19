/*Задайте двумерный массив из целых чисел.Найдите среднее арифметическое
элементов в каждом столбце. Например задан массив
1 4 7 2
4 9 2 3
8 4 2 4
среднее арифметическое каждого столбца : 4,6; 5,6; 3,6; 3.
*/
int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int[,] GetRandom2DArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 6);
        }
    }
    return array;
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void SredArif (int[,] array)
{
    double sredArif = 0;
    double summ = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            summ += array[i,j];
        }
        sredArif = summ / array.GetLength(0);
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.Write(Math.Round(sredArif, 2) + "\t");
        summ = 0;
        sredArif = 0;
    }
    Console.ResetColor();       
}


int[,] arrayRnd = GetRandom2DArray(4, 4);
Print2DArray(arrayRnd);
SredArif(arrayRnd);
