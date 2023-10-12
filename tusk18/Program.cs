/*Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/

System.Console.WriteLine("введите номер четверти: ");
int userCvoter = Convert.ToInt32(Console.ReadLine());

if (userCvoter == 1)
{
    System.Console.WriteLine("Все x больше 0 и y больше 0");
}
if (userCvoter == 2)
{
    System.Console.WriteLine("Все x меньше 0 и y больше 0");
}
if (userCvoter == 3)
{
    System.Console.WriteLine("Все x и y меньше 0");
}
if (userCvoter == 4)
{
    System.Console.WriteLine("Все x больше 0 и y меньше 0");
}