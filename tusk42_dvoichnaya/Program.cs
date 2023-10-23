/*Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/


int Prompt(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
string Conv(int number)
{
    string result = "";
    int tmp = 0;
    for (int i = number; i > 0; i/=2)
    {
        tmp = i % 2;
        result = tmp + result;
    }
    return result;
}

int uNum = Prompt("Введите число: ");
System.Console.WriteLine(Conv(uNum));