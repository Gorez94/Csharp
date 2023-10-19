/*31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
 Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
 положительных чисел равна 29, сумма отрицательных равна -20.
*/
/*int[] GetArray()
{
    int[] array = new int[12];
    for (int i = 0;i < 12; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
    return array;
}
void PrintArray(int[] arr)
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < arr.length; i++)
    {
        if (arr[i] < 0)
    {
        sumNeg += arr[i];
    }
    else if (arr[i] > 0)
    {
    sumPositive += arr[i];
    }
        System.Console.WriteLine($"{arr[i]}, ");
    }
    
    System.Console.WriteLine("Сумма положительных" + sumPos);
    System.Console.WriteLine("Сумма отрицательных" + sumNeg);
}

int[] userArray = GetArray;
PrintArray(array);*/


int Prompt(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    int pozitive = 0;
    int negative = 0;

    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");

        if (array[i] > 0)
            pozitive = pozitive + array[i];
        else
            negative = negative + array[i];
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма положительных чисел:\t {pozitive}");
    System.Console.WriteLine($"Сумма отрицательных чисел:\t{negative}");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значене для дапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);