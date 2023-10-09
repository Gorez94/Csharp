/*
16.Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

if (number * number == second || number == second * second)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}