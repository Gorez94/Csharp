/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
void Summ(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма = {summ} ");
        return;
    }
    Summ(m, n - 1, summ);
}
 System.Console.WriteLine("Введите число1: ");
int m = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("Введите число2: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

Summ(m, n, temp = 0);
