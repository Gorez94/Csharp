/*Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("День недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("понедельник");   
}
else
if (number == 2)
{
    Console.WriteLine("вторник");
}
else
if (number == 3)
{
    Console.WriteLine("среда");
}
else
if (number ==4)
{
    Console.WriteLine("четверг");
}
else
if (number == 5)
{
    Console.WriteLine("пятница");
}
else
if (number == 6)
{
    Console.WriteLine("суббота");
}
else
if (number == 7)
{
    Console.WriteLine("Воскресение");
}
else
System.Console.WriteLine("нет такого дня недели");
if (number == 6 || number == 7)
{
    System.Console.WriteLine("Это выходной");
}
else
{
    System.Console.WriteLine("Рабочий день");
}