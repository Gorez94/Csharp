/*47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/


int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


double[,] GetArray(int row, int column)
{
    double[,] array = new double[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10) + new Random().NextDouble();
        }
    }
    return array;
}


void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
int userArrayStart = TakeEnteredNumber("Введите начало диапозона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапозона:");
double[,] user2DArray = GetArray(userArrayRow, userArrayColumn);

PrintArray(user2DArray);