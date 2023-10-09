/*Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. 
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

if (number % second == 0)
{
    System.Console.WriteLine("Второе число кратно первому");
}
else
{
    System.Console.WriteLine(number % second);
}