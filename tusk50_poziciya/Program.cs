/*50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/


int[,] GetArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
        System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PoiskElementa(int[,] arr, int rows,int colomn)
{
    int iskomoe = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(rows == i && colomn == j)
            {
                iskomoe = arr[i, j];
                break;
            }
        }
        
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"{rows} и {colomn} -> {iskomoe}");
}

int rowsMass = 5;
int colomnMass = 5;

int[,] arrayPoisk = GetArray(rowsMass, colomnMass);
PrintArray(arrayPoisk);
System.Console.WriteLine();
System.Console.WriteLine("Введите строку: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите столбец: ");
int colomn = Convert.ToInt32(Console.ReadLine());
if (rows >= rowsMass || colomn >= colomnMass)
{
    System.Console.WriteLine();
    System.Console.WriteLine($"{rows} и {colomn} -> Нет числа, адресс не верный");
}
else
{
    PoiskElementa(arrayPoisk, rows, colomn);
}