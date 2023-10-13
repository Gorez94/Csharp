/*Напишите программу, которая выводит третью цифру
 заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = n / 100;

if (n > 100)
{
    System.Console.WriteLine(result % 10);
}
else
{
    System.Console.WriteLine("Число двузначное, третьей цифры нет");
}